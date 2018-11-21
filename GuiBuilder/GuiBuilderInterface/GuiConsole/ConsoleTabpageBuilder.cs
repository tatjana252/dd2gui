using GuiBuilder.GuiBuilderInterface;
using GuiBuilder.GuiControls;

namespace GuiBuilder.GuiConsole
{
	public class ConsoleTabpageBuilder : IGuiComponentBuilder
	{
		public object CreateComponentRepresentation(IGuiControl control)
		{
			TabPage tp = control as TabPage;
			foreach (var tpChildControl in tp.ChildControls)
			{
				new GuiBuilderConsole().CreateBuilder(tpChildControl).CreateComponentRepresentation(tpChildControl);
			}
			return null;
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