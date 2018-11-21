using System;
using GuiBuilder.GuiBuilderInterface;

namespace GuiBuilder.GuiHtml
{
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