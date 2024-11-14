using System;
using System.IO;
namespace Assignment_5
{
    class Program3
    {
        static void Main()
        {
            Console.Write("Enter the file path: ");
            string filePath = Console.ReadLine();

            if (File.Exists(filePath))
            {
                try
                {
                    
                    string[] lines = File.ReadAllLines(filePath);
                    int lineCount = lines.Length;

                   
                    Console.WriteLine($"The file contains {lineCount} lines.");
                    Console.Read();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    Console.Read();
                }
            }
            else
            {
                Console.WriteLine("The specified file does not exist.");
                Console.Read();
            }
        }
    }
}

