using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Triangle
    {
        double k1=0;
        double k2=0;

        public static double Square(double x, double y)
        {
           return 0.5 * x * y;
        }
        public static double Gip(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}
