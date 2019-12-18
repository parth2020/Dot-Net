using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indexer1
{
    class Indexer_Class
    {
        int[] x = new int[3];
        double[] y = new double[3];

        public object this[int i]
        {
            set
            {
                if (i <= 2)
                    x[i] = Convert.ToInt16(value);
                else
                    y[i-3] = Convert.ToDouble(value);
            }

            get
            {
                if (i <= 2)
                    return x[i];
                else
                    return y[i-3];
            }
        }
    }
}
