﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka.GuiControls
{
	public class Combobox : IInputField
	{
		public void Create()
		{
			Console.WriteLine(String.Format("{0, 15}{1, 1}┌───────────────┐┌───┐", Name, (Required) ? "*" : " "));
			Console.WriteLine(String.Format("{0, 15}{1, 1}│               ││ V │", "", " "));
			Console.WriteLine(String.Format("{0, 15}{1, 1}└───────────────┘└───┘", "", " "));
		}

		public IGuiControl ParentControl { get; set; }
		public string Name { get; set; }
		public bool Required { get; set; }
	}
}
