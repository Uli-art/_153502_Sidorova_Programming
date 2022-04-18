namespace Task_1
{
    enum Type
    {
        Single,
        Double,
        Triple,
        Quadruplу,
        family,
        VIP
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter name of Hotel: ");
            string name = Console.ReadLine();
            Hotel hotel = Hotel.GetInstance(name);
            hotel.AddRoom(1, 34.2, 4);
            hotel.AddRoom(27, 67.8, 1);
            hotel.AddRoom(2, 176.3, 5);
            hotel.AddRoom(154, 98.7, 3);
            hotel.Registration("Ivan");
            hotel.Registration("Timur");
            hotel.Registration("Masha");
            hotel.AddOrder("Ivan",27);
            hotel.AddOrder("Rita", 1);
            hotel.AddOrder("Masha", 13);
            hotel.AddOrder("Timur", 27);
            List<Room> rooms = hotel.getFreeRoom();
            for (int i = 0; i < rooms.Count(); ++i) {
                Console.WriteLine(rooms[i].getNumber() + " " + rooms[i].getCost() + " " + rooms[i].isFree() + " " + (Type)rooms[i].getTypeOfRoom());
            }
            Console.WriteLine(hotel.GetPrice("Ivan"));
            Console.WriteLine(hotel.GetPrice("Rita"));
            Console.WriteLine(hotel.GetPrice("Timur"));
        }
    }
}