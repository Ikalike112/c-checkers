using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    public class Function
    {    
        public static double z1(double x, double y)
        {
            return (1 / (x - y)) * (Math.Pow(Math.E, x) - (Math.Sqrt(y) / (Math.Pow((y - x), 2))));
           
        }
        public static double z2(double x, double y)
        {
            return Math.Sqrt(x + (1 / (1 + (1 / y))));
          
        }

    }
}
