using System;
using System.Collections.Generic;
using System.Text;

namespace GuiBuilder.GuiBuilderInterface
{
	public interface IGuiBuilder
	{
		IGuiControlBuilder CreateBuilder(IGuiControl control);
	}
}
