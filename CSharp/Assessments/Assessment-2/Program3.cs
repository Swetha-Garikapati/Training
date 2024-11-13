using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
    class Program3
    {
        static void CheckPositiveNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("The number cannot be negative");
            }
        }
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter a number");
                int userInput = Convert.ToInt32(Console.ReadLine());
                CheckPositiveNumber(userInput);
                Console.WriteLine("The number is valid");
                Console.Read();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error:" + ex.Message);
                Console.Read();
            }
            catch (FormatException)
            {
                Console.WriteLine("Error:Please enter a valid integer");
                Console.Read();
            }
        }
    }
}
