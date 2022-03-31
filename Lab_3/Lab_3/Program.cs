// Variant 8
using System;

namespace Task_1
{
    public class Program
    {
        public static int CheckInputInt()
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Error input! try again");
            }
            return a;
        }

        public static int CheckAndModify(int value)
        {
            if (value % 2 == 0)
            {
                return value / 2;
            }
            return value + 3;
        }

        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("Enter number");
                int value = CheckInputInt();
                Console.WriteLine(CheckAndModify(value) + "\n");
                Console.WriteLine("Do you want to continue? ( y(yes), n(no) )");
                answer = Console.ReadLine();
                answer = answer.ToLower();
            } while (answer == "yes" || answer == "y");
        }
    }
}
