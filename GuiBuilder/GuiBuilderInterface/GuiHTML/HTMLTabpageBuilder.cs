using System;
using GuiBuilder.GuiBuilderInterface;
using GuiBuilder.GuiControls;
using GuiBuilder.GuiControls.GuiControlsImplementation;

namespace GuiBuilder.GuiHtml
{
	public class HTMLTabpageBuilder : IGuiControlBuilder
	{
		public object CreateComponentRepresentation(IGuiControl control)
		{
			TabPage tp = control as TabPage;
			Console.WriteLine($"<div id=\"{control.Name}\" class=\"tabcontent\">");
			foreach (var tpChildControl in tp.ChildControls)
			{
				new GuiBuilderHTML().CreateBuilder(tpChildControl).CreateComponentRepresentation(tpChildControl);
			}

			Console.WriteLine("</div>");
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