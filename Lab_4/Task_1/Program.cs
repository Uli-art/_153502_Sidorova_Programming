using System;
//using Hotels;

namespace Hotels
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of Hotel: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter count Of Populated Places: ");
            int populatedPlaces = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter count Of Places: ");
            int places = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter rate: ");
            int rate = int.Parse(Console.ReadLine());

            Hotel hotel = Hotel.GetInstance(name, populatedPlaces, places, rate); 

            Console.WriteLine("Total revenue: " + hotel.Calculate());

            Console.WriteLine("Enter how much to reduce rate: ");
            double minus = double.Parse(Console.ReadLine());
            hotel.DecreaseRate(minus);
            Console.WriteLine("Total revenue: " + hotel.Calculate());

            Console.WriteLine("Enter how much to increase rate: ");
            double plus = double.Parse(Console.ReadLine());
            hotel.IncreaseRate(plus);
            Console.WriteLine("Total revenue: " + hotel.Calculate());
        }
    }
}
