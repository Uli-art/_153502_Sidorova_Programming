// Variant 18
// Calculation error: 10^(-4);
using System;

namespace Task_2
{
    public class Program2
    {
        const double intersection = 7.071;
        const int radius = 10;
        public static int Check(double x, double y)
        {
            if (Math.Abs(x) > 10 || Math.Abs(y) > 10) {
                return -1;
            }
            if (x >= -intersection && x <= intersection && y >= 0) {
                if (Math.Abs(x) > y)
                {
                    return 1;
                }
                else if (Math.Abs(x) == y) { return 0; }
                return -1;
            }
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(radius, 2) + 0.0001) && (Math.Pow(x, 2) + Math.Pow(y, 2) >= Math.Pow(radius, 2) - 0.0001)) { return 0; }
            return 1;
        }

        public static double CheckInputDouble()
        {
            double a;
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Error input! try again");
            }
            return a;
        }

        public static void InputAndOutput()
        {
            Console.WriteLine("Enter the first coordinate");
            double x = CheckInputDouble();//Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second coordinate");
            double y = CheckInputDouble();//Convert.ToInt32(Console.ReadLine());
            int result = Check(x, y);
            if (result == -1)
            {
                Console.WriteLine("Point does not lie in this area");
            }
            else if (result == 0)
            {
                Console.WriteLine("Point lies on the boundary");
            }
            else
            {
                Console.WriteLine("point does lie in this area");
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

