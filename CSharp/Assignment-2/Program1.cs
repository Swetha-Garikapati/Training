using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program1
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter the first number");
                string a = Console.ReadLine();
                Console.WriteLine("Enter the second number");
                string b = Console.ReadLine();
                string c = b;
                b = a;
                a = c;
                Console.WriteLine("The value of a= {0} and the value of b ={1}", a, b);
            Console.Read();

         }

        }
    }

