using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, address;
            int acc_no;
            double balance;
            double intrate;
            int custid;

            Console.WriteLine("--------------- Enter Account Details ---------------");
            Console.WriteLine("Enter Account Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Address:");
            address = Console.ReadLine();
            Console.WriteLine("Enter Customer Id");
            custid = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Account Number");
            acc_no = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Intrest Rate");
            intrate = Convert.ToDouble(Console.ReadLine());

            o: 
            Console.WriteLine("Enter Balance");
            balance = Convert.ToDouble(Console.ReadLine());
            if (balance < 5000)
            {
                Console.WriteLine("!!!! Please Enter Valid Ammount !!!!");
                goto o;
            }
            else
            {
                saving o = new saving(name, address, acc_no, balance, custid, intrate);
                o.printdata();
                Console.WriteLine("--------------- DEPOSIT ---------------");
                o.deposit();
                double r;
                Console.WriteLine("--------------- WITHDRAW ---------------");
                Console.WriteLine("Enter Ammount To Withdraw");
                r = Convert.ToDouble(Console.ReadLine());
                o.withdraw(r);

                o.printdata();

            }

            Console.ReadKey();
        }

    }
}
