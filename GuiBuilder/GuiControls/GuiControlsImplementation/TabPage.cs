﻿using System;
using System.Collections.Generic;
using System.Text;
using GuiBuilder;
using GuiBuilder.GuiBuilderInterface;

namespace GuiBuilder.GuiControls.GuiControlsImplementation
{
	public class TabPage : IContainer
	{
		public IGuiControl ParentControl { get; set; }
		public string Name { get; set; }
		public List<IGuiControl> ChildControls { get; set; } = new List<IGuiControl>();

		
	}
}
