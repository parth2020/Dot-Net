using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shape
{
    namespace TwoD
    {
        class Area
        {
            public void calcArea(double r)
            {
                Console.WriteLine("Area of Circle is: " + (3.14 * r * r));
            }

            public void calcArea(double l,double b)
            {
                Console.WriteLine("Area of Rectangle is: " + (l * b));
            }

            public void calcArea(int a)
            {
                Console.WriteLine("Area of Square is: " + (a * a));
            }
        }
    }

    namespace ThreeD
    {
        class Volume
        {

        }
    }
}
