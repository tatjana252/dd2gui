using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteka.GuiControls.ConsoleBuild
{
	public class ConsoleTabpageBuilder : IBuilder
	{
		public object CreateComponentRepresentation(IGuiControl control)
		{
			TabPage tp = control as TabPage;
			foreach (var tpChildControl in tp.ChildControls)
			{
				
			}
			return null;
		}
	}

	public class ConsoleTableBuilder : IBuilder
	{
		public object CreateComponentRepresentation(IGuiControl control)
		{
			IspisKomponenti.IspisiTabelu(((Table)control).Columns);
			return "Table";
		}
	}

	public class ConsoleTabControlBuilder : IBuilder
	{
		
		public object CreateComponentRepresentation(IGuiControl control)
		{
			TabControl tc = (TabControl) control;
			IspisKomponenti.IspisiKartice(tc.Pages.Select(p => p.Name).ToList());
			return "TabControl";
		}
	}

	public class ConsolePanelBuilder : IBuilder
	{
		public object CreateComponentRepresentation(IGuiControl control)
		{
			return "Panel";
		}
	}

	public class ConsoleGroupboxBuilder : IBuilder
	{
		public object CreateComponentRepresentation(IGuiControl control)
		{
			return "Groupbox";
		}
	}

	public class ConsoleComboboxBuilder : IBuilder
	{
		public object CreateComponentRepresentation(IGuiControl control)
		{
			IspisKomponenti.IspisiCombobox(control.Name, ((Combobox)control).Required);
			return "Combobox";
		}
	}

	public class ConsoleTextBoxBuilder : IBuilder
	{
		public object CreateComponentRepresentation(IGuiControl control)
		{
			IspisKomponenti.IspisiTextbox(control.Name, ((TextBox)control).Required);
			return "TextBox";
		}
	}
}
