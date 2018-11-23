using System;
using GuiBuilder.GuiBuilderInterface;

namespace GuiBuilder.GuiConsole
{
	public class ConsolePanelBuilder : IGuiControlBuilder
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
}