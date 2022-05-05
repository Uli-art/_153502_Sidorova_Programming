using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public abstract class Sport
    {
        protected string? type;
        protected string? rules;
        protected int countOfPlayers = 0;

        public Sport() {
            Console.WriteLine("Constructor of the class Sport was called");
        }

        public string Print() {
            string text = type + "\nRules: " + rules + "\nCount Of Players: " + countOfPlayers;
            Console.WriteLine(text);
            return text;
        }
        virtual public string Play() { 
            return "Play some game";
        }
        abstract public string getType();
        abstract public string getRules();
        abstract public int getCountOfPlayers();
        abstract public string ChangeRules(string newRules);    
    }
}
