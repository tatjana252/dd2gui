using System;
using System.Linq;
using GuiBuilder.GuiBuilderInterface;
using GuiBuilder.GuiControls;

namespace GuiBuilder.GuiHtml
{
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
}