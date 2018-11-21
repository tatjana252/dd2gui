using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka.GuiControls
{
	public interface IInputField : IGuiControl
	{
		bool Required { get; set; }
	}
}
