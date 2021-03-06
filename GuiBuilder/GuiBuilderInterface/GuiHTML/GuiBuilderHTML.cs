﻿using GuiBuilder.GuiBuilderInterface;
using System;

namespace GuiBuilder.GuiHtml
{
	public class GuiBuilderHTML : IGuiBuilder
	{
		public IGuiControlBuilder CreateBuilder(IGuiControl control)
		{
			IGuiControlBuilder builder = null;
			switch (control.GetType().Name)
			{
				case "TextBox":
					builder = new HTMLTextBoxBuilder();
					break;
				case "Combobox": builder = new HTMLComboboxBuilder(); break;
				case "Groupbox": builder = new HTMLGroupboxBuilder(); break;
				case "Panel": builder = new HTMLPanelBuilder(); break;
				case "TabControl": builder = new HTMLTabControlBuilder(); break;
				case "Table": builder = new HTMLTableBuilder(); break;
				case "TabPage": builder = new HTMLTabpageBuilder(); break;
				case "DateField": builder = new HTMLDateFieldBuilder(); break;
			}

			if (builder != null)
			{
				return builder;
			}

			throw new Exception();

		}
	}

	
}
