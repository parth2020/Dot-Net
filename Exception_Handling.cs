using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            try
            {
                Console.WriteLine("Enter 1st Value: ");
                a = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Enter 2nd Value: ");
                b = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Division Is: " + a / b);
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            finally
            {
                Console.WriteLine("Example of Divide by Zero Exception");
            }

            Console.ReadKey();
        }
    }
}
