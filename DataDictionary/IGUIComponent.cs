using System;
using System.Collections.Generic;
using System.Text;
namespace DataDictionary
{
    public interface IGUIComponent
    {
		string Name { get; set; }
		Composition Composition { get; set; }
	    DataDict DataDict { get; set; }
    }
}
