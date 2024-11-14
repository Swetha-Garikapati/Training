using System;
using System.IO;

namespace Assignment_5
{
    class Program2
    {
    static void Main()
        {
         
            Console.Write("Enter the number of strings you want to save to the file: ");
            int numberOfStrings = int.Parse(Console.ReadLine());

            
            string[] userStrings = new string[numberOfStrings];

            
            for (int i = 0; i < numberOfStrings; i++)
            {
                Console.Write($"Enter string {i + 1}: ");
                userStrings[i] = Console.ReadLine();
            }

           
            string filePath = "C:\\DotNet-Training\\CSharp\\Assignments\\Assignment-5\\userStrings.txt";

            try
            {
                
                File.WriteAllLines(filePath, userStrings);
                Console.WriteLine($"Strings written to {filePath} successfully!");
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while writing to the file: " + ex.Message);
                Console.Read();
            }
        }
    }
}

