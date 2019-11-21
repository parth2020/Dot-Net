using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using shape.TwoD;
using shape.ThreeD;

namespace NameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, l, b;
            int a;

            Console.WriteLine("Enter Value of Radius For Circle:  ");
            r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Value of Length For Rectangle:  ");
            l = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Value of Breadth For Rectangle:  ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Value of Side For Square:  ");
            a = Convert.ToInt16(Console.ReadLine());


            Area c = new Area();
            c.calcArea(r);
            c.calcArea(l , b);
            c.calcArea(a);

            Console.ReadKey();

        }

        
    }
}
