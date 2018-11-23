using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using GuiBuilder;
using GuiBuilder.GuiBuilderInterface;
using GuiBuilder.GuiControls.GuiControlsImplementation;

namespace GuiBuilder.GuiConsole
{
	public class ConsoleDateFieldBuilder : IGuiControlBuilder
	{
		public object CreateComponentRepresentation(IGuiControl p)
		{
			PrintComponentsConsole.PrintDateField(p.Name, ((DateField)p).Required);
			return null;
		}

		public object StartTag(IGuiControl p)
		{
			return null;
		}

		public object EndTag(IGuiControl p)
		{
			return null;
		}
	}
}
