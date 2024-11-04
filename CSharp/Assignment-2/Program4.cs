using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program4
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int temp = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the {0} element of array", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int n = 0; n < arr.Length - 1; n++)
            {
                for (int m = (n + 1); m < arr.Length; m++)
                {
                    if (arr[n] > arr[m])
                    {
                        temp = arr[n];
                        arr[n] = arr[m];
                        arr[m] = temp;
                    }
                    else continue;



                }
            }
            int sum = 0;
            foreach (int item in arr)
            {
                Console.Write("{0}", item);
            }
            Console.WriteLine();
            Array.ForEach(arr, j => sum = sum + j);
            float avg = sum / (arr.Length);
            Console.WriteLine("{0} is the average of array", avg);
            Console.WriteLine("{0} is the minimum element of array", arr[0]);
            Console.WriteLine("{0} is the maximum element of array", arr[(arr.Length - 1)]);

            Console.Read();

        }
       

    }
}

