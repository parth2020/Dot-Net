using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            ConstructorDemo o = new ConstructorDemo(); // defaut
            ConstructorDemo o1 = new ConstructorDemo("Prajit","Oxford University"); //
            ConstructorDemo o2 = new ConstructorDemo(); // static

            ConstructorDemo o3 = new ConstructorDemo(o); // copy constructor

            //ConstructorDemo oa = new ConstructorDemo()


            Console.ReadKey();
        }
    }
}
