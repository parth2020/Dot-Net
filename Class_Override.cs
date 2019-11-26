using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
       class Person
    {
        protected string name, address, email;
        protected int contact;
        public virtual void fetchdata()
        {
            Console.WriteLine("Enter your name ");
            name=Console.ReadLine();
            Console.WriteLine("Enter your address ");
            address=Console.ReadLine();
            Console.WriteLine("Enter your Email ");
            email=Console.ReadLine();
            Console.WriteLine("Enter your Number ");
            contact = Convert.ToInt16(Console.ReadLine());
        }
        public virtual void printdata()
        {
           
            Console.WriteLine("Name is "+name);
            Console.WriteLine("Addres is "+address);
            Console.WriteLine("Mail Id is "+email);
            Console.WriteLine("Contact is "+contact);
           
        }
    }
    class student : Person
    {
        int enrollno;
        double result;
        public override void fetchdata()
        {
            base.fetchdata();
            Console.WriteLine("Enter Your enrollno " );
            enrollno = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter your Result ");
            result = double.Parse(Console.ReadLine());
           

        }
        public override void printdata()
        {
            base.printdata();
            //Console.WriteLine("Name is "+name);
            //Console.WriteLine("Addres is "+address);
            //Console.WriteLine("Mail Id is "+email);
            //Console.WriteLine("Contact is "+contact);
            Console.WriteLine("Roll number is "+enrollno);
            Console.WriteLine("Result is "+result );
        }
    }

}

