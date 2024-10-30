using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number:");
            int num1 = Console.Read();
            Console.ReadLine();
            Console.WriteLine("Input second number:");
            int num2=Console.Read();
           Console.ReadLine();
            if (num1 == num2)
                Console.WriteLine("Both are equal");
            else
                Console.WriteLine("Both are not equal");
            Console.ReadLine();
        }
    }
}
