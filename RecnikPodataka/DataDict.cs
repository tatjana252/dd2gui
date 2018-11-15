using System;
using System.Collections.Generic;
using DataDictionary;


namespace DataDictionary
{
    public class DataDict
    {
		public List<Structure> Structures { get; set; }

	    public DataDict()
	    {
			Structures = new List<Structure>();
	    }

	   

	    public Structure CreateStructure(Composition composition, string v, List<IGUIComponent> komponentas)
	    {
		    Structure s = new Structure()
		    {
			    DataDict = this,
				Composition = composition,
				Name = v,
				ComponentsList = komponentas
		    };
			this.Structures.Add(s);
		    return s;
	    }

		public IGUIComponent CreateField(string v, Domain domain, Composition composition = Composition.Null)
		{
			return new Field()
			{
				DataDict = this,
				Name = v,
				Domain = domain, 
				Composition = composition
			};
		}


	    public IGUIComponent CreateStructure(Composition composition, List<IGUIComponent> komponentas)
	    {
			return new Structure()
		    {
			    DataDict = this,
			    Composition = composition,
			    ComponentsList = komponentas
		    };
		}
    }
}
