using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            obj[0] = 1;
            obj[1] = 5.55;
            obj[2] = "abc";

            Console.WriteLine("Int Is " +obj[0] + " Double Is " +obj[1]+ " String Is " +obj[2]);

            Console.ReadKey();
        }
    }
}
