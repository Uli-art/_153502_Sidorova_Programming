namespace Task_1
{
    class Program
    {
        static void Main()
        {
            string name = "deew";
            Hotel hotel = Hotel.GetInstance(name);
            hotel.AddRoomWithoutDiscount(1, 34.2);
            hotel.AddRoomWithDiscount(27, 67.8, 10);
            hotel.AddRoomWithoutDiscount(2, 176.3);
            hotel.AddRoomWithDiscount(154, 98.7, 3);
            
            List<Room> rooms = hotel.GetRooms();
            for (int i = 0; i < rooms.Count(); ++i)
            {
                Console.WriteLine(rooms[i].getNumber() + " " + rooms[i].GetPrice());
            }
            Console.WriteLine(hotel.GetAveragePrice());
        }
    }
}
