using System;
using System.Collections.Generic;
using System.Linq;
using Biblioteka.GuiControls;

namespace Biblioteka
{
	public class Struktura : IKomponenta
	{
		public string Naziv { get; set; }
		public List<IKomponenta> Komponente { get; set; }
		public Kompozicija Kompozicija { get; set; }
		public Recnik Recnik { get; set; }

		public IGuiControl IspisiFormuZaUnos(bool? obavezno = true)
		{
			IContainer result = new Panel();
			switch (Kompozicija)
			{
				case Kompozicija.Agregacija:
					result.ChildControls.AddRange(IspisiStrukturu(true));
					break;
				case Kompozicija.EkskluzivnaSpec:
					TabControl tabcontrol = new TabControl();
					foreach (var komponenta in Komponente)
					{
						TabPage tabpage = new TabPage();
						tabcontrol.Pages.Add(tabpage);
						tabpage.ChildControls.Add(komponenta.IspisiFormuZaUnos());
					}
					result = tabcontrol;
					break;
				case Kompozicija.NeekskluzivnaSpec:
					result.ChildControls.AddRange(IspisiStrukturu(false));
					break;
				case Kompozicija.Skup:
					result.ChildControls.Add(new Table(Komponente.Select(k => k.Naziv).ToList()));
					//IspisKomponenti.IspisiTabelu(Komponente.Select(k => k.Naziv).ToList());
					break;
				case Kompozicija.Null:
					break;
				default:
					break;
			}

			return result;
		}

		private List<IGuiControl> IspisiStrukturu(bool obaveznaPolja)
		{
			List<IGuiControl> controls = new List<IGuiControl>();
			foreach (var komponenta in Komponente)
			{
				controls.Add(komponenta.IspisiFormuZaUnos(obaveznaPolja));
			}

			return controls;
		}

		public Struktura(string naziv, List<IKomponenta> komponente, Kompozicija kompozicija)
		{
			Naziv = naziv;
			Komponente = komponente;
			Kompozicija = kompozicija;
		}

		public Struktura()
		{
		}
	}
}
