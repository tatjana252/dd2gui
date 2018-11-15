using System;
using System.Collections.Generic;
using System.Text;

namespace GuiBuilder.GuiBuilderInterface
{
	public interface IContainer : IGuiControl
	{
		List<IGuiControl> ChildControls { get; set; }

	}
}
