using System.Linq;
using GuiBuilder.GuiBuilderInterface;
using GuiBuilder.GuiControls;

namespace GuiBuilder.GuiConsole
{
	public class ConsoleTabControlBuilder : IGuiComponentBuilder
	{
		
		public object CreateComponentRepresentation(IGuiControl control)
		{
			return "TabControl";
		}

		public object StartTag(IGuiControl c)
		{
			TabControl tc = (TabControl) c;
			var kolone = tc.ChildControls.Select(p => p.Name).ToList();
			PrintComponentsConsole.PrintTabs(kolone);
			return "";
		}

		public object EndTag(IGuiControl p)
		{
			PrintComponentsConsole.PrintLine();
			return "";
		}
	}
}