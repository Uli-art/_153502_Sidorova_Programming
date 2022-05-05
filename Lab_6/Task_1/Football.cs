using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Football : Sport
    {
        string result;
        public Football() {
            type = "Football";
            rules = "";
            countOfPlayers = 11;
            result = "";
        }
        override public string getType() {
            return "Football";
        }
        public override string getRules() 
        { return rules; }
        override public int getCountOfPlayers() {
            return countOfPlayers;
        }
        public override string Play() {
            return "Play football";
        }
        override public string ChangeRules(string newRules)
        {
            rules = newRules;
            return rules;
        }
        public string ChangeRules()
        {
            rules = "";
            return rules;
        }
        public void setResults(string newResult)
        {
            result = newResult;
        }
        public new string Print()
        {
            string text = this.getType() + "\nRules: " + rules + "\nCount Of Players: " + this.getCountOfPlayers() + "\nResults: " + result;
            Console.WriteLine(text);
            return text;
        }
    }
}
