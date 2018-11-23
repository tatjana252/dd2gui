using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataDictionary
{
    public class Field : IComponent
    {
	    public string Name { get; set; }
		public Domain Domain { get; set; }
	    public string Semantics { get; set; }
	    public Composition Composition { get; set; } = Composition.Null;
	    public DataDict DataDict { get; set; }

	    

	    public Field(string name, Domain domain, string semantics, Composition composition, DataDict dataDictionary)
		{
			Name = name;
			Domain = domain;
			Semantics = semantics;
			Composition = composition;
			DataDict = dataDictionary;
		}

		public Field()
		{
		}

		public Field(string name, Domain domain, DataDict dataDictionary)
		{
			Name = name;
			Domain = domain;
			DataDict = dataDictionary;
		}
	}
}
