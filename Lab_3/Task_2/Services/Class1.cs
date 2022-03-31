using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Services
{
    public class Class1
    {
        public static double Calculate(double value)
        {
            double x;
            if (value < -1.0) {
                Console.WriteLine("Branch #1");
                x = -value / 3;
            }
            else
            {
                Console.WriteLine("Branch #2");
                x = Math.Abs(value);
            }
            return Math.Log(0.5 + x) + (Math.Exp(x) - Math.Exp(-x));
        }
    }
}
