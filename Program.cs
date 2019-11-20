using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,n,m,flag=0;
            Console.WriteLine("Enter Number");
            n = Convert.ToInt16(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    flag = 1;
                    break;
                }

            }
            if (flag == 1)
                Console.WriteLine("Not Prime");
            else
                Console.WriteLine("Number is Prime");

            Console.ReadKey();
        }
    }
}
