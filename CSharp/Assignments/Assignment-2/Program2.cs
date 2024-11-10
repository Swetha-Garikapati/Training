using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program2
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Enter the number");
                string d = Console.ReadLine();
                string e = d + " ";
                for (int i = 1; i < 5; i++)
                {
                    Console.WriteLine();
                    for (int j = 1; j < 5; j++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(d);
                        }
                        else
                        {
                            Console.Write(e);
                        }


                    }

                }
            Console.Read();
            }
        }
    }


