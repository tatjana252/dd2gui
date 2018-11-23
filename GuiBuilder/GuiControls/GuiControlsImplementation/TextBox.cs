using System;
using System.Collections.Generic;
using System.Text;
using GuiBuilder;
using GuiBuilder.GuiBuilderInterface;

namespace GuiBuilder.GuiControls.GuiControlsImplementation
{
	public class TextBox : IInputField
	{
		public IGuiControl ParentControl { get; set; }
		public string Name { get; set; }
		public bool Required { get; set; }
	}
}
