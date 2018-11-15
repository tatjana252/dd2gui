using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Biblioteka.GuiControls
{
	public class TabControl : IContainer
	{
		public void Create()
		{

		}

		public IGuiControl ParentControl { get; set; }
		public string Name { get; set; }
		public List<IGuiControl> ChildControls { get; set; } = new List<IGuiControl>();
		public List<TabPage> Pages { get; set; } = new List<TabPage>();
	}
}
