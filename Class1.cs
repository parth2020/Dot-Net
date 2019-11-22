using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication23
{
    class Class1
    {
        int a, b;

        public Class1() // default
        {
            Console.WriteLine("Default Constructor Called ");
            a = 2;
            b = 3;
        }

        
        public Class1(Class1 o) // copy
        {
            a = o.a;
            b=o.b;

            Console.WriteLine("Value of A is " + a +" And B is "+b);

        }

       /* public void Add(Class1 o1, Class1 o2)
        {
            this.a = o1.a + o2.a;
            this.b = o1.b + o2.b;

            Console.WriteLine("A is "+this.a+" B is  "+ this.b);
        }  */

        public Class1 Add(Class1 o)
        {
            //Class1 obj = new Class1();

            o.a = this.a + o.a;
            o.b = this.b + o.b;

            return o;
        }
        public void show()
        {
            Console.WriteLine("A is "+this.a+" B is  "+ this.b);
        }
    }
}
