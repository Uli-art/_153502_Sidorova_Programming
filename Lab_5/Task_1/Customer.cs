using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Customer
    {
        string name;
        int numOforder;
        public Customer(string n) { 
            name = n;
            numOforder = -1;
        }
        public Customer(string n, int num) {
            name = n;
            numOforder = num;
            
        }

        public string getName() {
            return name;
        }

        public void setNumOfOrder(int num) {
            numOforder = num;
        }

        public int getNumOfOrder() {
            return numOforder;
        }
    }
}
