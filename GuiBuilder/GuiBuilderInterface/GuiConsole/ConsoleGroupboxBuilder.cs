using GuiBuilder.GuiBuilderInterface;

namespace GuiBuilder.GuiConsole
{
	public class ConsoleGroupboxBuilder : IGuiControlBuilder
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
}