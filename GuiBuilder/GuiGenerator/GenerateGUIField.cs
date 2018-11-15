using GuiBuilder.GuiBuilderInterface;
using GuiBuilder.GuiControls;
using System;
using System.Linq;
using DataDictionary;
using GuiBuilder.GuiControls.GuiControlsImplementation;

namespace GuiBuilder.GuiGenerator
{
	internal class GenerateGUIField
	{

		public static IGuiControl CreateFieldGui(Field p, bool? obavezno)
		{
			switch (p.Composition)
			{
				case Composition.Null:
					return CreateControlField(p, obavezno != null && (bool)obavezno);
				case Composition.ExclusiveSpecialization:
				case Composition.NonExclusiveSpecialization:
					return CreateControlField(p);
				case Composition.Set:
					return CreateSetField(p);
				default: throw new Exception();
			}
		}

		private static Table CreateSetField(Field p)
		{
			Structure struktura = p.DataDict.Structures.First(s => s.Name == p.Name);
			return (struktura != null) ? new Table(struktura.ComponentsList.Select(s => s.Name).ToList()) : null;
		}

		private static IInputField CreateControlField(Field p, bool obavezno = false)
		{
			switch (p.Domain)
			{
				case Domain.Int:
				case Domain.String:
					return new TextBox()
					{
						Name = p.Name,
						Required = obavezno
					};
				case Domain.Date:
					return new DateField()
					{
						Name = p.Name,
						Required = obavezno
					};
				case Domain.Structure:
					return new Combobox()
					{
						Name = p.Name,
						Required = obavezno
					};
				case Domain.Bool:
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}

			return null;
		}
	}
}
