using System;
using System.Collections.Generic;
using System.Linq;
using DataDictionary;
using GuiBuilder.GuiBuilderInterface;
using GuiBuilder.GuiControls;

namespace GuiBuilder.GuiGenerator
{
	internal class GenerateGUIStructures
	{
		public static IGuiControl  CreateStructureGUI(Structure s, bool? obavezno = true)
		{
			switch (s.Composition)
			{
				case Composition.Aggregation:
					return GetAgregationContainer(s);
				case Composition.ExclusiveSpecialization:
					return GetExclusiveSpecializationContainer(s);
				case Composition.NonExclusiveSpecialization:
					return GetNonExclusiveContainer(s);
				case Composition.Set:
					return GetSetContainer(s);
				default:
					throw new Exception();
			}
		}

		#region methods for Containers
		private static IGuiControl GetSetContainer(Structure s)
		{
			IContainer result = new Panel()
			{
				Name = s.Name
			};
			result.ChildControls.Add(new Table(s.ComponentsList.Select(k => k.Name).ToList()));
			return result;
		}

		private static IGuiControl GetNonExclusiveContainer(Structure struktura)
		{
			IContainer result = new Panel()
			{
				Name = struktura.Name,
			};
			List<IGuiControl> controls = new List<IGuiControl>();
			foreach (var komponenta in struktura.ComponentsList)
			{
				controls.Add(CreateGUI(komponenta, false));
			}

			result.ChildControls.AddRange(controls);
			return result;
		}

		private static IContainer GetAgregationContainer(Structure s)
		{
			IContainer result = new Panel()
			{
				Name = s.Name,
			};
			List<IGuiControl> controls = new List<IGuiControl>();
			foreach (var komponenta in s.ComponentsList)
			{
				controls.Add(CreateGUI(komponenta, true));
			}

			result.ChildControls.AddRange(controls);
			return result;
		}

		private static IContainer GetExclusiveSpecializationContainer(Structure s)
		{
			TabControl tabcontrol = new TabControl()
			{
				Name = s.Name
			};
			foreach (var komponenta in s.ComponentsList)
			{
				TabPage tabpage = new TabPage()
				{
					Name = komponenta.Name,
				};
				tabcontrol.ChildControls.Add(tabpage);
				tabpage.ChildControls.Add(CreateGUI(komponenta));
			}

			return tabcontrol;
		}

		public static IGuiControl CreateGUI(IGUIComponent component, bool obavezno = true)
		{
			switch (component)
			{
				case Structure s:
					return CreateStructureGUI(s, obavezno);
				case Field p:
					return GenerateGUIField.CreateFieldGui(p, obavezno);
				default:
					throw new Exception();
			}
		}
		#endregion


	}
}
