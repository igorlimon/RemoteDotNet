using System;

namespace Recap
{
    class QWidget
    {
    }

    class QwtAnalogClock : QWidget
    {
        public DateTime Time { get; set; }
    }

    class QwtCompass : QWidget
    {
        public string Direction { get; set; }
    }

    class OperatoIsAndAs
    {
        static void DisplayTime(QWidget widget)
        {
            if (widget is QwtAnalogClock)
            {
                var qwtAnalogClock = (QwtAnalogClock)widget;// as QwtAnalogClock;
                Console.WriteLine(qwtAnalogClock.Time);
            }
            else
            {
                var qwtAnalogClock = widget as QwtAnalogClock;
                Console.WriteLine("N.A.");
            }
        }

        public static void Run()
        {
            QwtAnalogClock analogClock = new QwtAnalogClock()
            {
                Time = DateTime.Now
            };
            DisplayTime(analogClock);

            QwtCompass compass = new QwtCompass()
            {
                Direction = "North"
            };
            DisplayTime(compass);

            object o = "12345";
            Console.WriteLine(o as string == null ? 0 : (o as string).Length);
            Console.WriteLine(((string)o).Length);
        }
    }
}
