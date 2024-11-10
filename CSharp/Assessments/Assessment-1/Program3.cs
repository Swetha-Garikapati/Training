using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1
{
    class Program3
    {
        static void Main()
        {
            
            Console.WriteLine("Enter the first integer:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second integer:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third integer:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int largest;

            if (num1 >= num2 && num1 >= num3)
            {
                largest = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                largest = num2;
            }
            else
            {
                largest = num3;
            }


            Console.WriteLine("The largest integer is: " + largest);
            Console.Read();
        }
    }
}
