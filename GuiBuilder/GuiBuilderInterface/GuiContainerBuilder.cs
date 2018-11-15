using System;
using System.Collections.Generic;
using System.Text;
using GuiBuilder.GuiConsole;
using GuiBuilder.GuiControls;

namespace GuiBuilder.GuiBuilderInterface
{
	public class GuiContainerBuilder
	{
		public static void CreateGUI(IContainer container, IGuiBuilder builder)
		{
			foreach (var containerChildControl in container.ChildControls)
			{
				IGuiComponentBuilder componentBuilder = builder.CreateBuilder(containerChildControl);
				if (containerChildControl is IContainer kon)
				{
					componentBuilder.StartTag(kon);
					CreateGUI(kon, builder);
					componentBuilder.EndTag(kon);
				}
				else if (containerChildControl is IInputField field)
				{
					componentBuilder.CreateComponentRepresentation(field);
				}
			}
		}


	}
}
