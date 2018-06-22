using System;
using System.IO;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStreamRun();
            StreamReaderRun();
            StreamWriterRun();
        }

        private static void StreamWriterRun()
        {
            string[] names = new string[] { "Zara Ali", "Nuha Ali" };

            using (StreamWriter sw = new StreamWriter("names.txt"))
            {
                foreach (string s in names)
                {
                    sw.WriteLine(s);
                }
            }

            string line = "";
            using (StreamReader sr = new StreamReader("names.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            Console.ReadKey();
        }

        private static void StreamReaderRun()
        {
            using (StreamReader sr = new StreamReader("../../jamaica.txt"))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            Console.ReadKey();
        }

        private static void FileStreamRun()
        {
            try
            {
                FileStream fileStream = new FileStream("test.dat", FileMode.OpenOrCreate,
                    FileAccess.ReadWrite);
                for (int i = 1; i <= 20; i++)
                {
                    fileStream.WriteByte((byte)i);
                }

                fileStream.Position = 0;
                for (int i = 0; i <= 20; i++)
                {
                    Console.Write(fileStream.ReadByte() + " ");
                }

                fileStream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }


    }
}
