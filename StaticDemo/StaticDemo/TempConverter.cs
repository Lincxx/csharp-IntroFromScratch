using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class TempConverter
    {
        public static double CtoF(string tempC)
        {
            double c = Double.Parse(tempC);
            double f = (c * 9 / 5) + 32;
            return f;
        }

        public static double FtoC(string tempF)
        {
            double f = Double.Parse(tempF);
            double c = (f - 32) *  5/9;
            return c;
        }
    }
}
