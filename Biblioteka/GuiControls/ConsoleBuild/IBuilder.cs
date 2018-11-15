using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka.GuiControls.ConsoleBuild
{
	public interface IBuilder
	{
		object CreateComponentRepresentation(IGuiControl p);
	}
}
