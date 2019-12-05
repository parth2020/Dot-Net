using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Property
{
    class Property_Class
    {

        int _enroll,_m1,_m2,_m3;
        string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int enroll
        {
            get { return _enroll; }
            set { _enroll = value; }
        }
        
        public int m1
        {
            get { return _m1; }
            set { _m1 = value; }
        }

        public int m2
        {
            get { return _m2; }
            set { _m2 = value; }
        }

        public int m3
        {
            get { return _m3; }
            set { _m3 = value; }
        }

        public void show()
        {
            Console.WriteLine("---------------- Your Details ----------------");
            Console.WriteLine();
            Console.WriteLine("Hello is: "+name);
            Console.WriteLine("Roll Number: " +enroll);
            Console.WriteLine("Percentage: " +((m1+m2+m3)/3));
        }
    }
}
