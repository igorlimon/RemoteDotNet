using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap
{
    class EventsAndDelegates
    {
        public delegate void Start();
        public class Car
        {
            private readonly string _name;

            public Car(string name)
            {
                _name = name;
            }

            public void TurnOn()
            {
                WelcomeMessage();
                StartCar();
            }

            public Start WelcomeMessage { get; set; }

            public event Start StartCar;
        }

        static void WelcomeLogan()
        {
            Console.WriteLine("Hello Logan");
        }

        static void WelconeDuster()
        {
            Console.WriteLine("Hello Duster");
        }

        static void StartEngine()
        {
            Console.WriteLine("Start Engine");
        }

        static void TurnOnLights()
        {
            Console.WriteLine("Turn On Lights");
        }

        static void TurnOnRadio()
        {
            Console.WriteLine("Turn on Radio");
        }

        public static void Run()
        {
            var daciaLogan = new EventsAndDelegates.Car("Logan");
            daciaLogan.WelcomeMessage = WelcomeLogan;
            var daciaDuster = new EventsAndDelegates.Car("Duster");
            daciaDuster.WelcomeMessage = WelconeDuster;

            daciaLogan.StartCar += StartEngine;
            daciaLogan.StartCar += TurnOnLights;

            daciaDuster.StartCar += StartEngine;
            daciaDuster.StartCar += TurnOnLights;
            daciaDuster.StartCar += TurnOnRadio;

            daciaLogan.TurnOn();
            daciaDuster.TurnOn();
        }
    }
}
