using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public sealed class Backetball : Sport
    {
        public Backetball()
        {
            type = "Backetball";
            rules = "";
            countOfPlayers = 5;
        }
        override public string getType()
        {
            return "Backetball";
        }
        public override string getRules()
        {
            return rules;
        }
        override public int getCountOfPlayers()
        {
            return countOfPlayers;
        }
        
        override public string ChangeRules(string newRules)
        {
            rules = newRules;
            return newRules;
        }
    }
}
