using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor
{
    class ConstructorDemo
    {
        static int i = 0;
        int a, b;

        public ConstructorDemo() // default
        {
            Console.WriteLine("Default Constructor Called " +i++);
            a = 2;
            b = 3;
        }

        public ConstructorDemo(string name,string clg) //paramitarised
        {
            Console.WriteLine("Hello This Is " + name + " From " +clg);
        }

        static ConstructorDemo() // static
        {
            Console.WriteLine("Static Constructor Called " +i);
        }

        public ConstructorDemo(ConstructorDemo o) // copy
        {
            a = o.a;
            b=o.b;

            Console.WriteLine("Value of A is " + a +" And B is "+b);

        }
    }
}
