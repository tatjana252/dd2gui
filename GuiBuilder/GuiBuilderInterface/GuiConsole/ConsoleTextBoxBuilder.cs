using GuiBuilder.GuiBuilderInterface;
using GuiBuilder.GuiControls;
using GuiBuilder.GuiControls.GuiControlsImplementation;

namespace GuiBuilder.GuiConsole
{
	public class ConsoleTextBoxBuilder : IGuiControlBuilder
	{
		public object CreateComponentRepresentation(IGuiControl control)
		{
			PrintComponentsConsole.PrintTextbox(control.Name, ((TextBox)control).Required);
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