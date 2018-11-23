using GuiBuilder.GuiBuilderInterface;
using GuiBuilder.GuiControls.GuiControlsImplementation;

namespace GuiBuilder.GuiConsole
{
	public class ConsoleComboboxBuilder : IGuiControlBuilder
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