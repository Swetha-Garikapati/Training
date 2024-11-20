using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3
{
    public delegate int CalculatorOperation(int num1, int num2);
    class Program4
    {
        static int Add(int num1,int num2)
        {
            return num1 + num2;
        }
        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            CalculatorOperation operation;
            operation = Add;
            int result = operation(num1, num2);
            Console.WriteLine($"Addition: {result}");

           
            operation = Subtract;
            result = operation(num1, num2);
            Console.WriteLine($"Subtraction:  = {result}");

           
            operation = Multiply;
            result = operation(num1, num2);
            Console.WriteLine($"Multiplication:  = {result}");
            Console.Read();
        }  
    }
}

