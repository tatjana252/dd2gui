using System;
using GuiBuilder.GuiBuilderInterface;

namespace GuiBuilder.GuiHtml
{
	public class HTMLTableBuilder : IGuiControlBuilder
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
}