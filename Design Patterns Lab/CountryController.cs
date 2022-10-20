using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Lab
{
    public class CountryController
    {
        public List<Country> CountryDb { get; set; } = new List<Country>()
        {
            new Country("USA", "North America", new List<string> {"Red", "White", "Blue"}),
            new Country("Guatemala", "North America", new List<string> {"Blue", "White"}),
            new Country("Croatia", "Europe", new List<string> {"Red", "White", "Blue"}),
            new Country("Ireland", "Europe", new List<string> {"Green", "White", "Orange"}),
            new Country("Gambia", "Africa", new List<string> {"Red", "Blue", "White", "Green"}),
            new Country("Zambia", "Africa", new List<string> {"Red", "Black", "Orange", "Green"}),
            new Country("Japan", "Asia", new List<string> {"Red","White"}),
            new Country("Kazakhstan", "Asia", new List<string> {"Cyan","Gold"})

        };
        
        public void WelcomeAction()
        {
            bool goAgain = true;
            while (goAgain == true)
            {                
                CountryListView cl = new CountryListView(CountryDb);

                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:\n");
                CountryListAction();
                
                goAgain = AskToContinue();
            }
        }
        public void CountryListAction()
        {
            CountryListView clv = new CountryListView(CountryDb);
            int index = clv.Display();

            Country choice = CountryDb[index];
            CountryAction(choice);
        }
        public void CountryAction(Country country)
        {
            CountryView cv = new CountryView(country);
            cv.Display();
        }
        public static bool AskToContinue()
        {
            Console.WriteLine("\nWould you like to learn about another country? Y/N");
            string response = Console.ReadLine().ToLower();
            
            if(response == "y")
            {
                return true;
            }
            else if(response == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("I'm sorry I didn't understand that. Please try again.");
                return AskToContinue();
            }
        }
    }
}
