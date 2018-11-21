using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using GuiBuilder;
using GuiBuilder.GuiBuilderInterface;

namespace GuiBuilder.GuiHtml
{
	
		public class HTMLDateFieldBuilder : IGuiComponentBuilder
		{
			public object CreateComponentRepresentation(IGuiControl control)
			{
				Console.WriteLine($"{control.Name} <input type=\"date\"/>");
				return "TextBox";
			}

			public object StartTag(IGuiControl p)
			{
				return "";
			}

			public object EndTag(IGuiControl p)
			{
				return "";
			}
		}
}
