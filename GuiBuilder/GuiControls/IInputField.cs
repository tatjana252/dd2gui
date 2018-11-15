using System;
using System.Collections.Generic;
using System.Text;

namespace GuiBuilder.GuiBuilderInterface
{
	public interface IInputField : IGuiControl
	{
		bool Required { get; set; }
	}
}
