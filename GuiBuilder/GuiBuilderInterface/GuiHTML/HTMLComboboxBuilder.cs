using System;
using GuiBuilder.GuiBuilderInterface;

namespace GuiBuilder.GuiHtml
{
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
}