using GuiBuilder.GuiBuilderInterface;
using System;

namespace GuiBuilder.GuiConsole
{
	public class GuiBuilderConsole : IGuiBuilder
	{
		public IGuiControlBuilder CreateBuilder(IGuiControl control)
		{
			IGuiControlBuilder builder = null;
			switch (control.GetType().Name)
			{
				case "TextBox":
					builder = new ConsoleTextBoxBuilder();
					break;
				case "Combobox": builder = new ConsoleComboboxBuilder(); break;
				case "Groupbox": builder = new ConsoleGroupboxBuilder(); break;
				case "Panel": builder = new ConsolePanelBuilder(); break;
				case "TabControl": builder = new ConsoleTabControlBuilder(); break;
				case "Table": builder = new ConsoleTableBuilder(); break;
				case "TabPage": builder = new ConsoleTabpageBuilder(); break;
				case "DateField": builder = new ConsoleDateFieldBuilder();
					break;
			}

			if (builder != null)
			{
				return builder;
			}

			throw new Exception();

		}
	}

	
}
