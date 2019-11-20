using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, r;
            Console.WriteLine("Enter number of Pattern");
            r = Convert.ToInt16(Console.ReadLine());
            for (i = 1; i <= r; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
