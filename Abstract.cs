using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {

            //Class1 o = new Class1();
            
            //Class1 o1 = new Class1(o);
            
            //Class1 o2 = new Class1();
            ////o2.Add(o,o3);

            //o2=o.Add(o1);
            //o2.show();

            AbstractDemo o = new AbstractDemo();
            o.display();
            o.show();

            Console.ReadKey();
        }
    }
}
