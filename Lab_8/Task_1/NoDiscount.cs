using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class NoDiscount : IPrice
    {
        private double price;

        public NoDiscount(double pr)
        {
            price = pr;
        }

        public double GetPrice()
        {
            return price;
        }
    }
}
