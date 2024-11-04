using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");

            int n = Convert.ToInt32(Console.ReadLine());

            int[] array1 = new int[n];
            for (int i=0; i<n; i++)
            {
                Console.WriteLine("enter the {0} element:", i + 1);
            array1[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The given array is");
            for(int i=0;i<array1.Length;i++)
            {
                Console.WriteLine(array1[i] + " ");
            }
            int[] array2 = new int[n];
            for (int z = 0; z < n; z++)
            {
                array2[z] = array1[z];

            }
            Console.WriteLine("The copied array is");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array2[i] + " ");
            }
            Console.WriteLine();
            Console.Read();



        }

    }

}
    

