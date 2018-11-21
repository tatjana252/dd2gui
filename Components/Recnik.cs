using System;
using System.Collections.Generic;

namespace Biblioteka
{
    public class Recnik
    {
		public List<Struktura> StruktureRecnika { get; set; }

	    public Recnik()
	    {
			StruktureRecnika = new List<Struktura>();
	    }

	    public void KreirajPredlogeKorisnickogInterfejsa()
	    {
			List<IGuiControl> kontrole = new List<IGuiControl>();
		    foreach (var struktura in StruktureRecnika)
		    {
			    Console.WriteLine($"Predlog forme za unos {struktura.Naziv}:\n");
			    IGuiControl control = struktura.IspisiFormuZaUnos();
				kontrole.Add(control);
				IGuiComponentsBuilder.kreirajPredlog(control as IContainer);
				Console.WriteLine("\n\n\n");
		    }
		}

	    public Struktura KreirajStrukturu(Kompozicija kompozicija, string v, List<IKomponenta> komponentas)
	    {
		    Struktura s = new Struktura()
		    {
			    Recnik = this,
				Kompozicija = kompozicija,
				Naziv = v,
				Komponente = komponentas
		    };
			this.StruktureRecnika.Add(s);
		    return s;
	    }

		public IKomponenta KreirajPolje(string v, Domen domen, Kompozicija kompozicija = Kompozicija.Null)
		{
			return new Polje()
			{
				Recnik = this,
				Naziv = v,
				Domen = domen, 
				Kompozicija = kompozicija
			};
		}


	    public IKomponenta KreirajStrukturu(Kompozicija kompozicija, List<IKomponenta> komponentas)
	    {
			return new Struktura()
		    {
			    Recnik = this,
			    Kompozicija = kompozicija,
			    Komponente = komponentas
		    };
		}
    }
}
