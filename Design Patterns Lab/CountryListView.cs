using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Lab
{
    public class CountryListView
    {
        public List<Country> Countries { get; set; } = new List<Country>();
        public CountryListView(List<Country> Countries)
        {
            this.Countries = Countries;
        }

        public int Display()
        {
            for(int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine(i + " " + Countries[i].Name);
            }
            int index = int.Parse(Console.ReadLine());
            return index;
        }
    }
}
