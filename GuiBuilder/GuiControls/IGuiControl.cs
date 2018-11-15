using System;
using System.Collections.Generic;
using System.Text;

namespace GuiBuilder.GuiBuilderInterface
{
	public interface IGuiControl
	{
		IGuiControl ParentControl { get; set; }
		string Name { get; set; }
	}

	
}
