using System;
using System.Collections.Generic;
using System.Text;
using GuiBuilder;
using GuiBuilder.GuiBuilderInterface;
using GuiBuilder.GuiConsole;


namespace GuiBuilder.GuiControls
{
	public class Table : IInputField
	{
		public IGuiControl ParentControl { get; set; }
		public string Name { get; set; }
		public bool Required { get; set; }
		public List<string> Columns { get; set; }

		public Table(List<string> columns)
		{
			Columns = columns;
		}
	}
}
