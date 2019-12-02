using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            student o = new student();

            o.getdata();

            string n, p;
            System.Console.WriteLine();
            System.Console.WriteLine();
            Console.WriteLine("-------------------- Login -------------------- ");

            Console.WriteLine("Enter Name: ");
            n = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            p = Console.ReadLine();

            if (o.login(n, p) == 1)
                o.showdata();
            else
                Console.WriteLine("Invalid Name or Password");

            Console.ReadKey();

        }
    }
}
