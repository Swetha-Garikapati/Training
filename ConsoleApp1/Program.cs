using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static int Calculator(int a, int b, out int sum, out int product,out int divide)
        {
            sum = a + b;  //addition
            product = a * b;  //multiplication
            divide = a / b;  //division
            return a - b; // difference
        }
        static void Main(string[] args)
        {
            int Total, Prod, Div, Difference;

            Difference =Calculator(12, 6, out Total, out Prod,out Div);
            Console.WriteLine("Sum = {0} Product = {1} Div ={2} Difference = {3}", Total, Prod, Difference, Div);

            Console.Read();
            
        }
    }
}
