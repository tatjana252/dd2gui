using System;
using Biblioteka.GuiControls;
using Biblioteka.GuiControls.ConsoleBuild;

namespace Biblioteka
{
	public class IGuiComponentsBuilder
	{
		public static void kreirajPredlog(IContainer kontainer)
		{
			foreach (var kontainerChildControl in kontainer.ChildControls)
			{
				if (kontainerChildControl is IContainer kon)
				{
					kreirajPredlog(kon);
				}
				else if (kontainerChildControl is IInputField field)
				{
					ComponentBuilderFactory.Instance.GetBuilder(field).CreateComponentRepresentation(field);
				}
			}
		}


	}
}
