using System;

namespace Task_1
{
    public class Programm
    {
        static void Main(string[] args)
        {
            Sport newSport = new Football();
            newSport.Print();
            Console.WriteLine("\n");
            newSport.ChangeRules("qer");
            Football football = (Football)newSport;
            football.setResults("0:0");
            football.Print();
            Console.WriteLine("\n");
            Console.WriteLine(football.Play());
            Console.WriteLine("\n");
            football.ChangeRules();
            football.Print();
            Console.WriteLine("\n");

            Backetball backetball = new Backetball();
            Console.WriteLine(backetball.Play());
            Console.WriteLine("\n");
            backetball.ChangeRules("vfy");
            backetball.Print(); 
            
        }
    }
}