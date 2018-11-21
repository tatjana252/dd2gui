using GuiBuilder.GuiBuilderInterface;
using System.Collections.Generic;
using DataDictionary;

namespace GuiBuilder.GuiGenerator
{
	public class GenerateGUI
	{
		public static List<IContainer> CreateContainersForDataDictionary(DataDict r)
		{
			List<IContainer> containers = new List<IContainer>();
			foreach (var structure in r.Structures)
			{
				IContainer control = GenerateGUIStructures.CreateStructureGUI(structure) as IContainer;
				containers.Add(control);
			}

			return containers;
		}
	}
}
