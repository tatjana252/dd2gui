using System;
using System.Collections.Generic;
using System.Linq;
using DataDictionary;

namespace DataDictionary

{
	public class Structure : IGUIComponent
	{
		public string Name { get; set; }
		public List<IGUIComponent> ComponentsList { get; set; }
		public Composition Composition { get; set; }
		public DataDict DataDict { get; set; }


		public Structure(string name, List<IGUIComponent> komponente, Composition composition)
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
