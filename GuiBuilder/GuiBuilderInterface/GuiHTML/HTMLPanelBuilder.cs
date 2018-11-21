using System;
using GuiBuilder.GuiBuilderInterface;

namespace GuiBuilder.GuiHtml
{
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
}