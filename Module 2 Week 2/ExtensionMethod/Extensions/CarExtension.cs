using System;

namespace ExtensionMethod.Extensions
{
    public static class CarExtension
    {
        public static void Fly(this Car car)
        {
            Console.WriteLine($"Car {car.Model} can fly");
        }
    }
}