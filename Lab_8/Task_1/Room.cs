using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Room
    {
        int number;
        IPrice info;

        /* public Room(int num, double p, double dis)
         {
             number = num;
             info = new Discount(p, dis);

          public Room(int num, double p)
         {
             number = num;
             info = new NoDiscount(p);
         }
         }*/

        public Room(int num, IPrice inf) {
            number = num;
            info = inf;
        }
       
        public int getNumber()
        {
            return number;

        }

        public double GetPrice() { 
            return info.GetPrice(); 
        }
    }
}

