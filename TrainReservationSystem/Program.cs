using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TrainReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Train Reservation System");
            while (true)
            {
                Console.WriteLine("\n1. Admin\n2. User\n3. Exit");
                Console.Write("Choose an option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Admin.ShowMenu();
                        break;
                    case 2:
                        User.ShowMenu();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Invalid Option! Try again.");
                        break;
                }
            }
        }
    }
}
