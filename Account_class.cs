using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Account
{
    class Account_class
    {
        protected string name, address;
        protected int acc_no;
        protected double balance;

        public virtual void printdata()
        {
        }
    }

    class saving : Account_class,itrans
    {
        double intrate;
        int custid;

        public saving(string name , string address, int acc_no, double balance, int custid, double intrate)
        {
            this.name = name;
            this.address = address;
            this.acc_no = acc_no;
            this.balance = balance;
            this.custid = custid;
            this.intrate = intrate;

        }

        public override void printdata()
        {
            Console.WriteLine();
            Console.WriteLine("--------------- ACCOUNT DETAILS ---------------");
            Console.WriteLine("Hello "+name);
            Console.WriteLine("Account Number is: " + acc_no);
            Console.WriteLine("Balance is: " + balance);
            Console.WriteLine("Customer Id is:" +custid);
        }

        public void deposit()
        {
            double d;
            Console.WriteLine("Enter Ammount: ");
            d = Convert.ToDouble(Console.ReadLine());
            this.balance = this.balance + d;
            Console.WriteLine("Your Balance is:" +balance);
        }

        public double withdraw(double r)
        {
            if ((balance - r) < 5000)
            {
                Console.WriteLine("Not Able to Withdraw...");
                return 0;
            }
            else
            {
                this.balance = this.balance - r;
                return balance;
            }
        }

    }

    interface itrans
    {
        void deposit();
        double withdraw(double r);
    }
}
