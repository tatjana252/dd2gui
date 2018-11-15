using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Biblioteka.GuiControls.ConsoleBuild
{
	public class ComponentBuilderFactory
	{
		public static ComponentBuilderFactory _instance;

		private ComponentBuilderFactory()
		{

		}

		public static ComponentBuilderFactory Instance
		{
			get
			{
				if(_instance == null) _instance = new ComponentBuilderFactory();
				return _instance;
			}
		}

		public IBuilder GetBuilder(IGuiControl control)
		{
			switch (control.GetType().Name)
			{
				case "TextBox": return new ConsoleTextBoxBuilder();
				case "Combobox": return new ConsoleComboboxBuilder();
				case "Groupbox": return new ConsoleGroupboxBuilder();
				case "Panel": return new ConsolePanelBuilder();
				case "TabControl": return new ConsoleTabControlBuilder();
				case "Table": return new ConsoleTableBuilder();
				case "Tabpage": return new ConsoleTabpageBuilder();
			}

			throw new Exception();

		}


	}

	
}
