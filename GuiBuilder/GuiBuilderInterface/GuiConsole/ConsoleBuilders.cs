using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using GuiBuilder;
using GuiBuilder.GuiBuilderInterface;
using GuiBuilder.GuiControls;
using GuiBuilder.GuiControls.GuiControlsImplementation;

namespace GuiBuilder.GuiConsole
{
	public class ConsoleDateFieldBuilder : IGuiComponentBuilder
	{
		public object CreateComponentRepresentation(IGuiControl p)
		{
			PrintComponentsConsole.PrintDateField(p.Name, ((DateField)p).Required);
			return null;
		}

		public object StartTag(IGuiControl p)
		{
			return null;
		}

		public object EndTag(IGuiControl p)
		{
			return null;
		}
	}

	public class ConsoleTabpageBuilder : IGuiComponentBuilder
	{
		public object CreateComponentRepresentation(IGuiControl control)
		{
			TabPage tp = control as TabPage;
			foreach (var tpChildControl in tp.ChildControls)
			{
				new GuiBuilderConsole().CreateBuilder(tpChildControl).CreateComponentRepresentation(tpChildControl);
			}
			return null;
		}

		public object StartTag(IGuiControl p)
		{
			return "";
		}

		public object EndTag(IGuiControl p)
		{
			return "";
		}
	}

	public class ConsoleTableBuilder : IGuiComponentBuilder
	{
		public object CreateComponentRepresentation(IGuiControl control)
		{
			PrintComponentsConsole.PrintTable(((Table)control).Columns);
			return "Table";
		}

		public object StartTag(IGuiControl p)
		{
			return "";
		}

		public object EndTag(IGuiControl p)
		{
			return "";
		}
	}

	public class ConsoleTabControlBuilder : IGuiComponentBuilder
	{
		
		public object CreateComponentRepresentation(IGuiControl control)
		{
			return "TabControl";
		}

		public object StartTag(IGuiControl c)
		{
			TabControl tc = (TabControl) c;
			var kolone = tc.ChildControls.Select(p => p.Name).ToList();
			PrintComponentsConsole.PrintTabs(kolone);
			return "";
		}

		public object EndTag(IGuiControl p)
		{
			PrintComponentsConsole.PrintLine();
			return "";
		}
	}

	public class ConsolePanelBuilder : IGuiComponentBuilder
	{
		public object CreateComponentRepresentation(IGuiControl control)
		{
			return "Panel";
		}

		public object StartTag(IGuiControl p)
		{
			Console.WriteLine("Start Panel");
			return "Start Panel";
		}

		public object EndTag(IGuiControl p)
		{
			Console.WriteLine("End Panel");
			return "End Panel";
		}
	}

	public class ConsoleGroupboxBuilder : IGuiComponentBuilder
	{
		public object CreateComponentRepresentation(IGuiControl control)
		{
			return "Groupbox";
		}

		public object StartTag(IGuiControl p)
		{
			return "";
		}

		public object EndTag(IGuiControl p)
		{
			return "";

		}
	}

	public class ConsoleComboboxBuilder : IGuiComponentBuilder
	{
		public object CreateComponentRepresentation(IGuiControl control)
		{
			PrintComponentsConsole.PrintCombobox(control.Name, ((Combobox)control).Required);
			return "Combobox";
		}

		public object StartTag(IGuiControl p)
		{
			return "";
		}

		public object EndTag(IGuiControl p)
		{
			return "";
		}
	}

	public class ConsoleTextBoxBuilder : IGuiComponentBuilder
	{
		public object CreateComponentRepresentation(IGuiControl control)
		{
			PrintComponentsConsole.PrintTextbox(control.Name, ((TextBox)control).Required);
			return "TextBox";
		}

		public object StartTag(IGuiControl p)
		{
			return "";
		}

		public object EndTag(IGuiControl p)
		{
			return "";
		}
	}
}
