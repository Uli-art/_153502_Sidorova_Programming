using System;
using Task_3.Date;

namespace Task_3
{
    public class Program
    {
        public static DateTime CheckInputDate()
        {
            DateTime a;
            while (!DateTime.TryParse(Console.ReadLine(), out a))
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
                Console.WriteLine("Enter the date: ");
                DateTime date = CheckInputDate();
                Console.WriteLine("The day of week is " + DateServices.GetDay(date));
                Console.WriteLine("Days between the date and today's date - " +
                    DateServices.GetDaysSpan(date.Day, date.Month, date.Year, DateTime.UtcNow));
                Console.WriteLine("Do you want to continue? ( y(yes), n(no) )");
                answer = Console.ReadLine();
                answer = answer.ToLower();
            } while (answer == "yes" || answer == "y");
        }
    }
}
