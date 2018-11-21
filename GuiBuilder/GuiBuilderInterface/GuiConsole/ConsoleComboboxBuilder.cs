using GuiBuilder.GuiBuilderInterface;
using GuiBuilder.GuiControls;

namespace GuiBuilder.GuiConsole
{
	public class ConsoleComboboxBuilder : IGuiComponentBuilder
	{
		public object CreateComponentRepresentation(IGuiControl control)
		{
			PrintComponentsConsole.PrintCombobox(control.Name, ((Combobox)control).Required);
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