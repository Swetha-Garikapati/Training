using System;
using System.IO;

namespace Assessment_3
{
    class Program3
    {
        static void Main()
        
                {
                    string filePath = "C:\\DotNet-Training\\CSharp\\Assessments\\Assessment-3\\Swetha.txt";
                    Console.Write("Enter text to append: ");
                    string text = Console.ReadLine();

                    using (StreamWriter writer = File.AppendText(filePath))
                    {
                        writer.WriteLine(text);
                    }

                    Console.WriteLine("Text appended successfully.");
                    Console.WriteLine("Appended text:");
                    Console.WriteLine(File.ReadAllText(filePath));

                    Console.Read();
                }
            }
        }
       