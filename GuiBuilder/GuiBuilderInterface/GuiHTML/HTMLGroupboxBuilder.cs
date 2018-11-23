using GuiBuilder.GuiBuilderInterface;

namespace GuiBuilder.GuiHtml
{
	public class HTMLGroupboxBuilder : IGuiControlBuilder
	{
		public object CreateComponentRepresentation(IGuiControl control)
		{
			return "Groupbox";
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