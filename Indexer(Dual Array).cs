using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indexer1
{
    class Program
    {
        static void Main(string[] args)
        {
            Indexer_Class obj = new Indexer_Class();

            int i = 0;

            obj[0] = 1;
            obj[1] = 5;
            obj[2] = 9;

            obj[3] = 2.2;
            obj[4] = 6.6;
            obj[5] = 10.10;

            for (i = 0; i <= 5; i++)
            {
                Console.WriteLine(obj[i]);
            }

                Console.ReadKey();
        }
    }
}
