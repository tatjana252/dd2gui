using System;
using System.Collections.Generic;
using DataDictionary;
using GuiBuilder;
using GuiBuilder.GuiBuilderInterface;
using GuiBuilder.GuiConsole;
using GuiBuilder.GuiGenerator;


namespace GeneratorKI
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var recnik = new DataDict();

			recnik.CreateStructure(
				Composition.Aggregation, "Stavka narudzbenice", new List<IGUIComponent>
				{
					recnik.CreateField("Sifra", Domain.Int),
					recnik.CreateField("Kolicina", Domain.Int),
					recnik.CreateField("Proizvod", Domain.Structure)
				});


			recnik.CreateStructure(
				Composition.Aggregation,
				"Proizvod",
				new List<IGUIComponent>
				{
					recnik.CreateField("Sifra", Domain.Int),
					recnik.CreateField("Name", Domain.String),
					recnik.CreateStructure(
						Composition.NonExclusiveSpecialization,
						new List<IGUIComponent>
						{
							recnik.CreateField("Opis", Domain.String),
							recnik.CreateField("Napomena", Domain.String),
							recnik.CreateField("Cena", Domain.Int),
						}),
					recnik.CreateField("Proizvodjac", Domain.Structure),
				}
			);

			recnik.CreateStructure(Composition.Aggregation, "Narudzbenica",
				new List<IGUIComponent>
				{
					recnik.CreateField("Sifra", Domain.Int),
					recnik.CreateField("Date", Domain.Date),
					recnik.CreateField("Stavka narudzbenice", Domain.Structure, Composition.Set),
				});

			recnik.CreateStructure(Composition.Aggregation, "Kupac",
				new List<IGUIComponent>
				{
					recnik.CreateField("Sifra", Domain.Int),
					recnik.CreateField("Ulica", Domain.String),
					recnik.CreateStructure(
						Composition.ExclusiveSpecialization, new List<IGUIComponent>
						{
							recnik.CreateStructure(
								Composition.Aggregation, "Pravno lice", new List<IGUIComponent>
								{
									recnik.CreateField("PIB", Domain.Int),
									recnik.CreateField("Name Firme", Domain.String),
									recnik.CreateField("Adresa sedista", Domain.String)
								}),
							recnik.CreateStructure(
								Composition.Aggregation, "Fizicko lice", new List<IGUIComponent>
								{
									recnik.CreateField("Ime", Domain.String),
									recnik.CreateField("Prezime", Domain.String),
									recnik.CreateField("JMBG", Domain.String),
									recnik.CreateField("Adresa sedista", Domain.String)
								}),
						})});


			var ContainersForDictinary = GenerateGUI.CreateContainersForDataDictionary(recnik);

			var strukturaKupca = ContainersForDictinary[5];

			foreach (var guiControl in ContainersForDictinary)
			{

				Console.WriteLine(guiControl.Name);
				GuiContainerBuilder.CreateGUI(guiControl, new GuiBuilderConsole());
			}
		}

	}
}