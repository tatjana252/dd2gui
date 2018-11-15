using System;
using System.Collections.Generic;
using System.Text;
using GuiBuilder.GuiBuilderInterface;

namespace GuiBuilder.GuiControls.GuiControlsImplementation
{
	public class DateField : IInputField
	{
		public IGuiControl ParentControl { get; set; }
		public string Name { get; set; }
		public bool Required { get; set; }
	}
}
