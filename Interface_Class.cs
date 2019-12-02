using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    class Interface_Class
    {

    }

    abstract class person
    {
        protected string name, pass, dob;
        protected double contact;

        public abstract void getdata();

    }

    interface idetails
    {
        int login(string name, string pass);
        void showdata();
    }

    class student : person,idetails
    {
        int roll;
        string branch;
        double result;

        public override void getdata()
        {
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter Password: ");
            pass = Console.ReadLine();

            Console.WriteLine("Enter Date Of Birth: ");
            dob = Console.ReadLine();

            Console.WriteLine("Enter Contact Number: ");
            contact = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Roll Number: ");
            roll = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Branch Name: ");
            branch = Console.ReadLine();

            Console.WriteLine("Enter Your Result: ");
            result = Convert.ToDouble(Console.ReadLine());
        }

        public int login(string name, string pass)
        {

            if (name == this.name && pass == this.pass)
                return 1;
            else
                return 0;
 
        }

        public void showdata()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------- Details -------------------- ");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Hello " +name);
            Console.WriteLine("Roll Number is:" +roll);
            Console.WriteLine("Your Branch is: " +branch);
            Console.WriteLine("Result is: " +result);
            Console.WriteLine("Your Contact Number is " + contact);
        }
            
    }
}

