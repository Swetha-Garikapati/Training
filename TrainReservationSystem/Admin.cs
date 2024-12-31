using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainReservationSystem
{
    public static class Admin
    {
        public static void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\nAdmin Menu");
                Console.WriteLine("1. Add Trains\n2. Modify Trains\n3. Delete Trains \n4. Show all Trains\n5.Exit");
                Console.Write("Choose an option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        TrainService.AddTrain();
                        break;
                    case 2:
                        TrainService.ModifyTrain();
                        break;
                    case 3:
                        TrainService.DeleteTrain();
                        break;
                    case 4:
                        BookingService.ShowAllTrains();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid Option! Try again.");
                        break;
                }
            }
        }
    }
}
        