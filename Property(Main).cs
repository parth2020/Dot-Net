using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Property_Class o = new Property_Class();

            Console.WriteLine("Enter Your Name");
            o.name = Console.ReadLine();
            Console.WriteLine("Enter Roll Number");
            o.enroll = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Marks for Subject 1");
            o.m1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Marks for Subject 2");
            o.m2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Marks for Subject 3");
            o.m3 = Convert.ToInt16(Console.ReadLine());

            o.show();

            Console.ReadKey();
        }
    }
}
