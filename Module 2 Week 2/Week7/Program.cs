using System;
using System.Collections.Generic;
using System.Linq;

namespace Week7
{
    class Program
    {

        static void Main(string[] args)
        {
            Lambda();
        }

        private static void Syntax()
        {
            var numbers = new List<int>() {1, 4, -8, 9, -3};
          
            var positiveNumbers = numbers.Where(number => number >= 0);
            Console.WriteLine("Positive numbers");
            foreach (var number in positiveNumbers)
            {
                Console.WriteLine(number);
            }

            var negativeNumbers = from number in numbers where number < 0 select number;
            Console.WriteLine("Negative numbers");
            foreach (var negativeNumber in negativeNumbers)
            {
                Console.WriteLine(negativeNumber);
            }
        }

        private delegate string GetDay(DateTime value);

        private static string GetDate1(DateTime val)
        {
            return val.DayOfWeek.ToString();
        }

        private static void Lambda()
        {
            var dates = new List<DateTime>()
            {
                DateTime.Now.AddDays(0),
                DateTime.Now.AddDays(1),
                DateTime.Now.AddDays(2),
                DateTime.Now.AddDays(3),
                DateTime.Now.AddDays(4),
                DateTime.Now.AddDays(5),
                DateTime.Now.AddDays(6)
            };
            //foreach (var dateTime in dates)
            //{
            //    Console.WriteLine(dateTime);
            //}

            //var daysAsList = new List<string>();
            //foreach (var date in dates)
            //{
            //    daysAsList.Add(date.DayOfWeek.ToString());
            //}

            //foreach (var day in daysAsList)
            //{
            //    Console.WriteLine(day);
            //}
    
            GetDay getDay = delegate (DateTime val) { return val.DayOfWeek.ToString(); };
            var days = dates.Select(date => getDay(date));
            //Console.WriteLine("Days");
            //foreach (var day in days)
            //{
            //    Console.WriteLine(day);
            //}

            GetDay getDayAsLambda = val => val.DayOfWeek.ToString();

            days = dates.Select(date => getDayAsLambda(date));
            //Console.WriteLine("Days");
            //foreach (var day in days)
            //{
            //    Console.WriteLine(day);
            //}

            days = dates.Select(val =>
            {
                val = val.AddYears(1);
                return val.DayOfWeek.ToString();
            });
            //Console.WriteLine("Days");
            //foreach (var day in days)
            //{
            //    Console.WriteLine(day);
            //}

            IEnumerable<Car> cars = dates
                .Select(date => new Car() {Model = date.DayOfWeek.ToString()});
            foreach (var car in cars)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
