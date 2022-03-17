// Variant 19
using System;

namespace Task_1 {
    public class Program
    {

        public static int Check(int a, int b, int c) {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                return -1;
            }
            else if (a == b && a == c)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int CheckInputInt() {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Error input! try again");
            }
            return a;
        }

        public static void InputAndOutput()
        {
            Console.WriteLine("Enter the first side of the triangle ");
            int a = CheckInputInt();//Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second side of the triangle");
            int b = CheckInputInt();//Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third side of the triangle");
            int c = CheckInputInt();//Convert.ToInt32(Console.ReadLine());
            int result = Check(a, b, c);
            if (result == -1)
            {
                Console.WriteLine("No such triangle exists");
            }
            else if (result == 0)
            {
                Console.WriteLine("This triangle is not equilateral");
            }
            else
            {
                Console.WriteLine("This triangle is equilateral");
            }
        }

        
        static void Main(string[] args)
        {
            string answer;
            do
            {
                InputAndOutput();
                Console.WriteLine("Do you want to continue? ( y(yes), n(no) )");
                answer = Console.ReadLine();
                answer = answer.ToLower();
            } while (answer == "yes" || answer == "y");
        }
    }
}
   