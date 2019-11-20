using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ODD_EVEN
{
    class Program
    {
        static void Main(string[] args)
        {
             int a, b;
            Console.WriteLine("Enter a Number ");
            a = Convert.ToInt16(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("Number is even");
            else
                Console.WriteLine("Number is odd");
        }
        
    }
}
