using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Lab
{
    public class CountryView
    {
        public Country DisplayCountry { get; set; }
        public CountryView(Country DisplayCountry)
        {
            this.DisplayCountry = DisplayCountry;
        }
        public void Display()
        {
            Console.WriteLine("\nCountry Details:");
            Console.WriteLine("Name: " + DisplayCountry.Name);
            Console.WriteLine("Continent: " + DisplayCountry.Continent);
            Console.WriteLine("National Colors:");
            foreach(string color in DisplayCountry.Colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
