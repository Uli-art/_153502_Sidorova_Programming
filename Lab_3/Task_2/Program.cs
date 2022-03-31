// See https://aka.ms/new-console-template for more information
using System;
using Task_2.Services;

namespace Task_2
{
    public class Program
    {
        public static double CheckInputDouble()
        {
            double a;
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Error input! try again");
            }
            return a;
        }
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("Enter number(z): ");
                double z = CheckInputDouble();
                Console.WriteLine("y = " + Class1.Calculate(z));
                Console.WriteLine("Do you want to continue? ( y(yes), n(no) )");
                answer = Console.ReadLine();
                answer = answer.ToLower();
            } while (answer == "yes" || answer == "y");
        }
    }
}
