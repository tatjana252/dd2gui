using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka.GuiControls
{
	public interface IGuiControl
	{
		void Create();
		IGuiControl ParentControl { get; set; }
		string Name { get; set; }
	}

	
}
