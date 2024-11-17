using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Program2
    {
        static void Main()
        {
            Console.WriteLine("Enter the words ");
            string input = Console.ReadLine();
            List<string> words = input.Split(' ').ToList();
            var result = words.Where(word => word.StartsWith("a") && word.EndsWith("m")).ToList();
            Console.WriteLine("\nWords starting with 'a' and ending with 'm':");
            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
            Console.Read();
        }
    }
}