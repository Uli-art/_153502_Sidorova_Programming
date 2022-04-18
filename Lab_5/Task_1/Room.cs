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
        double cost;
        bool free;
        int typeOfRoom;
        public enum Type
        {
            Single,
            Double,
            Triple,
            Quadruplу,
            family,
            VIP
        }
        public Room(int num, double c, int t){ 
            number = num;
            cost = c;
            typeOfRoom = t;
            free = true;
        }
        public int getNumber()
        {
            return number;

        }
        public void ChangeFree() {
            free = false;
        }

        public bool isFree() { 
            return free;
        }

        public double getCost() {
            return cost;
        }

        public int getTypeOfRoom() {
            return typeOfRoom;
        }
    }
}
