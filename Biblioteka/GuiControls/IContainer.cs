using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka.GuiControls
{
	public interface IContainer : IGuiControl
	{
		List<IGuiControl> ChildControls { get; set; }
	}
}
