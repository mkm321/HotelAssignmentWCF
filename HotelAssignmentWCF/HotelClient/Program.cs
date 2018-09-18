using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelClient.HotelServiceReference;

namespace HotelClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelServiceClient hotelClient = new HotelServiceClient("BasicHttpBinding_IHotelService");
            int choice;
            do
            {
                Console.WriteLine("Enter 1 to Get all Hotels\n2 to Get Hotel By Id\n3Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: Hotel[] hotels = hotelClient.GetHotels();
                        foreach (Hotel hotel1 in hotels)
                        {
                            Console.WriteLine("Id is {0}\nName is {1}\nRating is {2}",hotel1.Id,hotel1.Name,hotel1.Rating);
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter ID");
                        int id = int.Parse(Console.ReadLine());
                        Hotel hotel = hotelClient.GetHotelById(id);
                        if (hotel != null)
                        {
                            Console.WriteLine("Id is {0}\nName is {1}\nRating is {2}", hotel.Id, hotel.Name, hotel.Rating);
                        }
                        else
                        {
                            Console.WriteLine("Wrong entry!");
                        }
                        Console.WriteLine();
                        break;
                    case 3: Console.WriteLine("Exiting...");
                        break;
                    default: Console.WriteLine("Wrong entry!");
                        break;
                }

            }
            while (choice!=3);
        }
    }
}
