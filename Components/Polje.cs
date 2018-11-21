using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka.GuiControls;

namespace Biblioteka
{
    public class Polje : IKomponenta
    {
	    public string Naziv { get; set; }
		public Domen Domen { get; set; }
	    public string Semanticki { get; set; }
	    public Kompozicija Kompozicija { get; set; } = Kompozicija.Null;
	    public Recnik Recnik { get; set; }

	    public IGuiControl IspisiFormuZaUnos(bool? obavezno)
	    {
			switch (Kompozicija)
			{
				case Kompozicija.Agregacija:
					break;
				case Kompozicija.Null:
					return IspisiPolje(obavezno != null && (bool) obavezno);
				case Kompozicija.EkskluzivnaSpec:
				case Kompozicija.NeekskluzivnaSpec:
					return IspisiPolje(false);
				case Kompozicija.Skup:
					Struktura struktura = Recnik.StruktureRecnika.First(s => s.Naziv == Naziv);
					if (struktura == null)
					{
						Console.WriteLine("Referencirate strukturu koja ne postoji u recniku!");
					}
					else
					{
						return new Table(struktura.Komponente.Select(s => s.Naziv).ToList());
						//IspisKomponenti.IspisiTabelu(struktura.Komponente.Select(s => s.Naziv).ToList());
					}
					
					break;
				default: break;
			}

		    return null;
	    }

	    private IInputField IspisiPolje(bool obavezno = false)
	    {
		    switch (Domen)
		    {
			    case Domen.Int:
			    case Domen.String:
			    case Domen.Datum:
				    return new TextBox()
				    {
					    Name = Naziv,
					    Required = obavezno
				    };
			    case Domen.Struktura:
				    return new Combobox()
				    {
					    Name = Naziv,
					    Required = obavezno
				    };
			    case Domen.Bool:
					//IspisKomponenti.IspisiCheckbox(Naziv);
				    break;
			    default:
				    throw new ArgumentOutOfRangeException();
		    }

		    return null;
	    }

	    public Polje(string naziv, Domen domen, string semanticki, Kompozicija kompozicija, Recnik recnik)
		{
			Naziv = naziv;
			Domen = domen;
			Semanticki = semanticki;
			Kompozicija = kompozicija;
			Recnik = recnik;
		}

		public Polje()
		{
		}

		public Polje(string naziv, Domen domen, Recnik recnik)
		{
			Naziv = naziv;
			Domen = domen;
			Recnik = recnik;
		}
	}
}
