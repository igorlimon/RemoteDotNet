using System;

namespace ExtensionMethod
{
    public class Car
    {
        public string Model { get; set; }

        public void Fly(Car car)
        {
            Console.WriteLine($"Car {car.Model} can fly1");
        }

        public void Drive()
        {
            Console.WriteLine("Drive");
        }
    }
}