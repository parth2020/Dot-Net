using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication23
{
    abstract class c1
    {
        public abstract void show();

        public void display()
        {
            Console.WriteLine("Non Absatract Method Called");
        }
    }
    class AbstractDemo:c1
    {
        public override void show()
        {
            Console.WriteLine("Abstract Method Inheritated");
        } 

    }
}
