using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program3
    {
        static void Main(string[] args)
        {
            int day;
            Console.WriteLine("Enter the day");
            day = Convert.ToInt32(Console.ReadLine());


            switch (day)
            {

                case 1:
                    Console.WriteLine("MONDAY");
                    break;
                case 2:
                    Console.WriteLine("TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine("THURSDAY");
                    break;
                case 5:
                    Console.WriteLine("FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("SATURDAY");
                    break;
                case 7:
                    Console.WriteLine("SUNDAY");
                    break;
                default:
                    Console.WriteLine("ENTER A VALID NO");
                    break;
            }
            Console.Read();

        }

    }
}

