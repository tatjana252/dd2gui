using GuiBuilder.GuiBuilderInterface;
using GuiBuilder.GuiControls;

namespace GuiBuilder.GuiConsole
{
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
}