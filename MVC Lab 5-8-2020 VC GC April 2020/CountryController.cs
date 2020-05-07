using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Lab_5_8_2020_VC_GC_April_2020
{
    //Lastly make a CountryController class. This class will be the big boss of your app. 
    class CountryController
    {
        //This class should have the following properties and methods: 
        //List<Country> CountryDb - this stands in for our country database 
        public List<Country> CountryDb { get; set; } = new List<Country>()
        {
            new Country("Spain", "Europe", new List<string> { "red", "yellow", "white" }),
            new Country("India", "Asia", new List<string> { "orange", "white", "green" }),
            new Country("Tanzania", "Africa", new List<string> { "green", "blue", "yellow", "black"}),
            new Country("USA", "North America", new List<string> { "red", "white", "blue"})

        };

        //default constructor
        public CountryController()
        {

        }

        //Public void CountryAction(Country c)  
        //This will take in a Country model, passing the model into the CountryView constructor, and call Display Country on your CountryView object. 
        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }

        //Public void WelcomeAction() - This will take no parameter and pass CountryDb into the CountryListView class. 
        //Then, it will print “Hello, welcome to the country app.Please select a country from the following list:” 
        //Then it will call Display() on the CountryListView.
        public void WelcomeAction()
        {
            CountryListView clv = new CountryListView(CountryDb);

            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list: ");

            clv.Display();

            //Next allow the user to select a country by index.
            //Upon getting the country out of CountryDb, pass that country along to the CountryAction() method.
            Console.WriteLine("Please select a Country from the list by Index");

            //for (int i = 0; i < CountryDb.Count; i++)
            //{
            //    Country c = CountryDb[i];
            //    Console.WriteLine($"{i}: {c.Name}");
            //}

            string input = Console.ReadLine();
            int index = int.Parse(input) - 1;

            Country output = CountryDb[index];
            CountryAction(output);

            while(true)
            {           
            //After that’s done, ask if the user would like to learn about another country. 
            Console.WriteLine("Would you like to learn about another country? Y/N");
            string response = Console.ReadLine().ToLower();

            try
            {
                if(response != "y" && response != "n")
                {
                    throw new FormatException("Invalid Response. Would you like to learn about another country? Y/N");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                continue;
            }
            if (response == "y")
            {
                WelcomeAction();
            }
            else if (response == "n")
            {
                Console.WriteLine("No problem! Have a great day!");
                break;
            }

            }

        }



    }
}
