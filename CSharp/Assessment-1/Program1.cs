using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1
{
    class Program1
    {
        static string RemoveCharAtPosition(string str, int pos)
        {
            if (pos < 0 || pos >= str.Length)
            {
                return "Invalid position.";
            }
            return str.Substring(0, pos) + str.Substring(pos + 1);
        }

        static void Main()
        {
           
            Console.Write("Enter a string: ");
            string userInput = Console.ReadLine();

            Console.Write("Enter the position to remove the character: ");
            int position;

            while (!int.TryParse(Console.ReadLine(), out position) || position < 0 || position >= userInput.Length)
            {
                Console.WriteLine("Invalid position.");
            }

            string result = RemoveCharAtPosition(userInput, position);
            Console.WriteLine("Resulting string: " + result);
            Console.Read();
        }
    }
}
    

