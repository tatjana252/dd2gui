using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using GuiBuilder;
using GuiBuilder.GuiBuilderInterface;
using GuiBuilder.GuiControls;

namespace GuiBuilder.GuiConsole
{
	
		public class HTMLDateFieldBuilder : IGuiComponentBuilder
		{
			public object CreateComponentRepresentation(IGuiControl control)
			{
				Console.WriteLine($"{control.Name} <input type=\"date\"/>");
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
	public class HTMLTabpageBuilder : IGuiComponentBuilder
	{
		public object CreateComponentRepresentation(IGuiControl control)
		{
			TabPage tp = control as TabPage;
			Console.WriteLine($"<div id=\"{control.Name}\" class=\"tabcontent\">");
			foreach (var tpChildControl in tp.ChildControls)
			{
				new GuiBuilderHTML().CreateBuilder(tpChildControl).CreateComponentRepresentation(tpChildControl);
			}

			Console.WriteLine("</div>");
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

	public class HTMLTableBuilder : IGuiComponentBuilder
	{
		public object CreateComponentRepresentation(IGuiControl control)
		{
			return "Table";
		}

		public object StartTag(IGuiControl p)
		{
			Console.WriteLine("<table>");
			return "";
		}

		public object EndTag(IGuiControl p)
		{
			Console.WriteLine("</table>");
			return "";
		}
	}

	public class HTMLTabControlBuilder : IGuiComponentBuilder
	{
		
		public object CreateComponentRepresentation(IGuiControl control)
		{
			return "TabControl";
		}

		public object StartTag(IGuiControl c)
		{
			TabControl tc = (TabControl) c;
			Console.WriteLine("<div class=\"tab\">");
			var kolone = tc.ChildControls.Select(p => p.Name).ToList();
			foreach (var kolona in kolone)
			{
				Console.WriteLine($"<button class=\"tablinks\"\">{kolona}</button>");
			}
			//IspisKomponenti.IspisiKartice(kolone);
			Console.WriteLine("</div>\r\n");
			return "";
		}

		public object EndTag(IGuiControl p)
		{
			//IspisKomponenti.PrintLine();
			return "";
		}
	}

	public class HTMLPanelBuilder : IGuiComponentBuilder
	{
		public object CreateComponentRepresentation(IGuiControl control)
		{
			return "Panel";
		}

		public object StartTag(IGuiControl p)
		{
			Console.WriteLine("<div>");
			return "Start Panel";
		}

		public object EndTag(IGuiControl p)
		{
			Console.WriteLine("<div>");
			return "End Panel";
		}
	}

	public class HTMLGroupboxBuilder : IGuiComponentBuilder
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

	public class HTMLComboboxBuilder : IGuiComponentBuilder
	{
		public object CreateComponentRepresentation(IGuiControl control)
		{
			Console.WriteLine($"{control.Name}< select >\r\n <option> </option> \r\n\t</ select >");
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

	public class HTMLTextBoxBuilder : IGuiComponentBuilder
	{
		public object CreateComponentRepresentation(IGuiControl control)
		{
			Console.WriteLine($"{control.Name} <input/>");
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
