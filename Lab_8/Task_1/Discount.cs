using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Discount : IPrice
    {
        private double discount;
        private double price;

        public Discount(double pr, double dis) {
            discount = dis;
            price = pr;
        }

        public double GetPrice()
        {
            return price - (price * discount/ 100);
        }
    }
}
