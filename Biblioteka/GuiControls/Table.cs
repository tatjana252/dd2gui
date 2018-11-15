using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka.GuiControls
{
	public class Table : IInputField
	{
		public void Create()
		{
			Console.WriteLine();
			IspisKomponenti.PrintRow(Columns.ToArray());
			IspisKomponenti.PrintLine();
			for (int i = 0; i < 5; i++)
			{
				IspisKomponenti.PrintEmptyRow(Columns.Count);
				IspisKomponenti.PrintLine();
			}
		}

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
