using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication12
{
    class Class1
    {
        int x;
        double y;
        string s;

        public object this[int i]
        {
            get
            {
                if (i == 0)
                    return x;
                else if (i == 1)
                    return y;
                else
                    return s;
            }

            set
            {
                if (i == 0)
                    x = Convert.ToInt16(value);
                else if (i == 1)
                    y = Convert.ToDouble(value);
                else
                    s = (string)value;
            }
        }
    }
}
