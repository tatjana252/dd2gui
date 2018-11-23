using GuiBuilder.GuiBuilderInterface;
using GuiBuilder.GuiControls;
using GuiBuilder.GuiControls.GuiControlsImplementation;

namespace GuiBuilder.GuiConsole
{
	public class ConsoleTableBuilder : IGuiControlBuilder
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
}