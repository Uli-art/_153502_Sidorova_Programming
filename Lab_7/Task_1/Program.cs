using System;

namespace Task_1
{
    public class Programm
    {
        static void Main(string[] args)
        {
            char[] chars = {'f','g','3','e','r','6'};
            Multiplicitycs first = new Multiplicitycs(chars);
            Multiplicitycs second = new Multiplicitycs(chars);
            Console.WriteLine(first == second);
            char[] chars1 = { '2', '3', '4', '5', '6', '7' };
            Multiplicitycs third = new Multiplicitycs(chars1);
            Multiplicitycs fourth = new Multiplicitycs(chars1);
            third = third + fourth;
            Console.WriteLine(third + '\n');
            third = third - fourth;
            Console.WriteLine(third + '\n');
            Console.WriteLine(third * fourth + '\n');
            char[] chars2 = { 'f', 'g', 'g', 'e', 'r', '6' };
            Multiplicitycs fifth = new Multiplicitycs(chars2);
            if (fifth)
            {
                Console.WriteLine("Array is not empty" + '\n');
            }
            else {
                Console.WriteLine("Array is empty" + '\n');
            }
            string text = "";
            text = first;
            Console.WriteLine(text + '\n');
            second = (Multiplicitycs)text;
            Console.WriteLine(second + '\n');
        }
    }
}
