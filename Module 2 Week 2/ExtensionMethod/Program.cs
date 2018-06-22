using ExtensionMethod.Extensions;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car()
            {
                Model = "Dacia"
            };

            car.Drive();
            car.Fly();
        }
    }
}
