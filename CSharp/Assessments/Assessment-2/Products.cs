using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
    class Products
    {
        public int ProductId;
        public string ProductName;
        public double Price;
    }
    class Program2
    {
        static void Main()
        {
            Products[] products = new Products[10];
            for (int i = 0; i < 10; i++)
            {
                products[i] = new Products();
                Console.WriteLine("Enter details for product");
                Console.WriteLine("Enter the Product Id");
                products[i].ProductId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Product Name");
                products[i].ProductName = Console.ReadLine();
                Console.WriteLine("Enter the Price");
                products[i].Price = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < 9; i++)
                for (int j = i + 1; j < 10; j++)
                {
                    if (products[i].Price > products[j].Price)
                    {
                        Products temp = products[i];
                        products[i] = products[j];
                        products[j] = temp;
                    }
                }
            Console.WriteLine("\nSorted products by price:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"ID:{products[i].ProductId},Name:{products[i].ProductName},Price:${products[i].Price}");
   
            }
            Console.Read();
        }
    }
}

