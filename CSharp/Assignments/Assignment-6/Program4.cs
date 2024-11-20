using System;
using ClassLibrary1;


namespace Assignment_6
{
    class Program4
    {
        static void Main()
        {
            Console.WriteLine("Enter Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            int Age = Convert.ToInt32(Console.ReadLine());
            Class1 obj = new Class1();
            obj.CalculateConcession(Name, Age);
            Console.Read();

        }


    }
}
