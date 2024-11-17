using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Program1
    {
        static void Main()
        {
            Console.WriteLine("Enter the integers:");
            var input = Console.ReadLine();
            List<int> numbers = input.Split(' ').Select(int.Parse).ToList();
            var result = from number in numbers
                         let square = number * number
                         where square > 20
                         select new { Number = number, Square = square };

            Console.WriteLine("\n\nNumbers and their squares greater than 20");

            foreach (var item in result)
            {
                Console.WriteLine($"Number: {item.Number}, Square: {item.Square}");
            }
            Console.ReadLine();
        }
    }
}