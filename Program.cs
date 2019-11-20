using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            float res;
            char c;
            Console.WriteLine("Enter Value of a");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Value of b");
            b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Choice");
            Console.WriteLine("+ For Addition");
            Console.WriteLine("- For Substraction");
            Console.WriteLine("* For Multiplication");
            Console.WriteLine("/ For Division");

            c = Convert.ToChar(Console.ReadLine());

            switch (c) {
                case '+':
                    res=a+b;
                    Console.WriteLine("Result is:" + res);
                    break;
                case '-':
                    res = a - b;
                    Console.WriteLine("Result is:" + res);
                    break;
                case '*':
                    res = a * b;
                    Console.WriteLine("Result is:" + res);
                    break;
                case '/':
                    res = a / b;
                    Console.WriteLine("Result is:" + res);
                    break;
                default:
                    break;


            }
            
            Console.ReadKey();
        }
    }
}
