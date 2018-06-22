using System;
using System.Collections.Generic;
using System.Linq;
using Week7;
using Car = ExtensionMethod.Car;

namespace QueryOperators
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void Filtering()
        {
            var names = new List<string>()
            {
                "John",
                "Marry",
                "Rick",
                "Tom"
            };

            var a = names
                .Where(name => name[0] == 'T')
                .Take(100)
                .ToList();

            Dictionary<string, int> namesStartWithT = names
                .Where(name => name.Contains('o'))
                .Where(name => name.Length > 3)
                .ToDictionary(name => name, name => name.Length);


            foreach (var name in namesStartWithT)
            {
                Console.WriteLine(name);
            }
        }

        static void Join()
        {
            var names = new List<string>()
            {
                "John",
                "Marry",
                "Mikel"
            };

            var romanianNames = new List<string>()
            {
                "Ion",
                "Maria",
                "Mihai"
            };

            //var listOfNames = names.Join(
            //    romanianNames, 
            //    name => name, 
            //    romanianName => romanianName,
            //    (name, romanianName) => );
        }
    }
}
