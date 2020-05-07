using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Lab_5_8_2020_VC_GC_April_2020
{

    //Make a Country model with the following properties:
    class Country
    {
        
        //Public string Name
        public string Name { get; set; }


        //Public string Continent
        public string Continent { get; set; }


        //Public List<string> Colors
        public List<string> Colors { get; set; }

        //Default constructor
        public Country()
        {

        }

        //overloaded constructor
        public Country(string name, string continent, List<string> colors)
        {
            Name = name;
            Continent = continent;
            Colors = colors;
        }

    }
}
