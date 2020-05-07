using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Lab_5_8_2020_VC_GC_April_2020
{
    //Create a CountryListView class. This view will take a list of countries in its constructor.
    
    class CountryListView
    {
        //It should have the following property and method:
        //Public List<Country> Countries - store the parameter from the constructor here. 

        public List<Country> Countries;

        //default constructor
        public CountryListView()
        {

        }

        public CountryListView(List<Country> countries)
        {
            Countries = countries;
        }

        //It should have the following property and method:
        //Public void Display() - Print the name of each country in the list along with the index for each country
        public void Display()
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine($"{i+1}: {Countries[i].Name}");
            }
        }

    }
}
