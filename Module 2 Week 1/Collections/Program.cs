using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleList();
            SimpleDictionary();
        }

        private static void SimpleList()
        {
            // Create a list of strings.  
            var colors = new List<string>();
            
            colors.Add("black");
            colors.Add("white");
            colors.Add("red");
            colors.Add("grey");

            // Iterate through the list.  
            foreach (var color in colors)
            {
                Console.Write(color + " ");
            }

            Console.WriteLine();
        }

        private static void SimpleDictionary()
        {
            var countries = new Dictionary<string, long>();
            countries.Add("Romanian", 19042936);
            countries.Add("United Kingdom", 65648000);
            countries.Add("United States", 325719178);
            countries.Add("France", 67158000);

            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }

            countries["Moldova"] = 4000000;
            Console.WriteLine(countries["Moldova"]);
            Console.WriteLine(countries["United Kingdom"]);
            KeyValuePair<string, long> firstCountry = countries.First();
            Console.WriteLine($"Name: {firstCountry.Key} :Population: {firstCountry.Value}" );
        }
    }
}
