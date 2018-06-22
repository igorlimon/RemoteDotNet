using System;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFinally(null);
        }

        class CustomException : System.Exception
        {
            public CustomException(string message) : base(message)
            {

            }

        }
        private static void TestThrow()
        {
            var d = 4;
            var d1 = 0;
            var r = d / d1;
        }

        static void TestCatch()
        {
            try
            {
                TestThrow();
            }
            catch (CustomException ex)
            {
                System.Console.WriteLine(ex);
            }
            catch (DivideByZeroException ex)
            {
                System.Console.WriteLine(ex);
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
        }

        static void TestFinally(CustomException n)
        {
            try
            {
                Console.WriteLine(n.ToString());
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Run code from finally block");
            }
        }

        static void TestRethrow1()
        {
            try
            {
                throw new System.Exception("TestRethrow1");
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
                throw;
            }
        }

        static void TestRethrow2()
        {
            try
            {
                TestRethrow1();
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        static void TestRethrow3()
        {
            try
            {
                throw new System.Exception("TestRethrow3");
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
                throw ex;
            }
        }

        static void TestRethrow4()
        {
            try
            {
                TestRethrow3();
            }
            catch (System.Exception ex)
            {
                throw new System.Exception("asa", ex);
            }
        }
    }
}
