 using System;
using System.Collections.Generic;
using System.Text;

namespace GuiBuilder.GuiBuilderInterface
{
	public interface IGuiControlBuilder
	{
		object CreateComponentRepresentation(IGuiControl p);
		object StartTag(IGuiControl p);
		object EndTag(IGuiControl p);
	}
}
