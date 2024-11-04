using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
        class Program1
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter first number:");
                int num1 = Console.Read();
                Console.ReadLine();
                Console.WriteLine("Enter second number:");
                int num2 = Console.Read();
                Console.ReadLine();
                if (num1 == num2)
                    Console.WriteLine("Both are equal");
                else
                    Console.WriteLine("Both are not equal");
                Console.ReadLine();
            }
        }
    }

