using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Lab_5_8_2020_VC_GC_April_2020
{   
    //Next Create a CountryView Class.
    class CountryView
    {
        
        //default constructor
        public CountryView()
        {
            
        }

        //In the constructor require a Country be taken in and set to DisplayCountry. 
        public CountryView(Country DisplayCountry)
        {
            this.DisplayCountry = DisplayCountry;
        }

        //Create the following property and method: Public Country DisplayCountry
        public Country DisplayCountry { get; set; }



        //Public void Display() - This method will print out the Name, Continent, and Colors of the Country DisplayCountry property
        public void Display()
        {
            Console.WriteLine("Here's the info for the countries");
            Console.WriteLine("Name: " + DisplayCountry.Name);
            Console.WriteLine("Continent: " + DisplayCountry.Continent);
            foreach (string color in DisplayCountry.Colors)
            {
                Console.WriteLine("Colors: " + color);
            }
            
        }

    }
}
