﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new student();
            p.fetchdata();
            p.printdata();

            Console.ReadKey();
        }
    }
}
