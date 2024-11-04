using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program5
    {
        static void Main(string[] args)
        {
            int[] studentmarks = new int[10];
            int use = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter the student marks {0}", i);
                studentmarks[i] = Convert.ToInt32(Console.ReadLine());


            }
            for (int q = 0; q < studentmarks.Length - 1; q++)
            {
                for (int r = q + 1; r < studentmarks.Length; r++)
                {
                    if (studentmarks[q] > studentmarks[r])
                    {
                        use = studentmarks[r];
                        studentmarks[r] = studentmarks[q];
                        studentmarks[q] = use;


                    }
                    else continue;

                }
            }
            int sumofmarks = 0;
            Array.ForEach(studentmarks, g => sumofmarks = sumofmarks + g);
            float averagemarks = sumofmarks / (studentmarks.Length);
            Console.WriteLine("{0} is the sum of marks", sumofmarks);
            Console.WriteLine("{0} is the average of array", averagemarks);
            Console.WriteLine("{0} is the minimum element of array", studentmarks[0]);
            Console.WriteLine("{0} is the maximum element of array", studentmarks[(studentmarks.Length - 1)]);
            Console.Write("asending order of the marks ");
            foreach (int num in studentmarks)
            {
                Console.Write("{0}  ", num);
            }


            Console.WriteLine();
            Array.Reverse(studentmarks);
            Console.Write("desending order of the marks ");
            foreach (int k in studentmarks)
            {
                Console.Write(k + " ");

            }
            Console.WriteLine();
            Console.Read();

        }

    }
}

