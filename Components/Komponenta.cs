using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using Biblioteka.GuiControls;

namespace Biblioteka
{
    public interface IKomponenta
    {
		string Naziv { get; set; }
		Kompozicija Kompozicija { get; set; }
	    Recnik Recnik { get; set; }
		IGuiControl IspisiFormuZaUnos(bool? obavezno = true);
    }
}
