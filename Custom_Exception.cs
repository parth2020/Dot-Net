using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Custom_Exception
{
    class Program
    {
        public void checkage(int a)
        {
            if (a <= 0)
                throw new CheckAgeException("Invalid Age");
        }

        static void Main(string[] args)
        {
            Program o = new Program();

            try
            {
                o.checkage(0);
            }

            catch (CheckAgeException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

        class CheckAgeException : ApplicationException
        {
            public CheckAgeException(String s)
                : base(s)
            {

            }
        }



    }
}
