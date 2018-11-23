using System;
using System.Collections.Generic;
using System.Linq;
using DataDictionary;

namespace DataDictionary

{
	public class Structure : IComponent
	{
		public string Name { get; set; }
		public List<IComponent> ComponentsList { get; set; }
		public Composition Composition { get; set; }
		public DataDict DataDict { get; set; }


		public Structure(string name, List<IComponent> komponente, Composition composition)
		{
			Name = name;
			ComponentsList = komponente;
			Composition = composition;
		}

		public Structure()
		{
		}
	}
}
