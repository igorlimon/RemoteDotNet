using System;

namespace Recap
{
    class Dynamic
    {
        public static void Run()
        {
            dynamic d;
            d = 100;
            Console.WriteLine(d.GetType());
            // Prints "System.Int32".

            d = "11";
            Console.WriteLine(d.GetType());
            // Prints "System.String".

            // The following line throws an exception at run time.
            d++;

            Console.WriteLine(d);
        }
    }
}
