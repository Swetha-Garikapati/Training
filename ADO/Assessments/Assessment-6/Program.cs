﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Assessment_6
{
    class program
    {
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static IDataReader dr;
        static void Main(string[] args)
        {
            insert();
            Console.Read();
        }

        static SqlConnection Connection()
        {
            
            conn = new SqlConnection("Data Source=ICS-LT-D244D68Z;Initial Catalog=Assessment_6;" +
                "Integrated Security=true;");
            Console.WriteLine("Connected to a database:");
            
            conn.Open();
            return conn;
        }
        static void insert()
        {
            try
            {
                Connection();
                Console.WriteLine("Connected to database...");

                
                cmd = new SqlCommand("sp_productsdetails", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                
                Console.Write("Enter Product name : ");
                string Pname = Console.ReadLine();

                Console.Write("Enter the Product price : ");
                int P_price = Convert.ToInt32(Console.ReadLine());


                
                cmd = new SqlCommand("insert into ProductDetails values(@product_name,@product_price)", conn);
                Console.WriteLine();
                Console.WriteLine("Query Executed...");

                cmd.Parameters.AddWithValue("@product_name", Pname);
                cmd.Parameters.AddWithValue("product_price", P_price);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("*** Product Details inserted Successfully ***");

                    cmd = new SqlCommand("Select * from ProductDetails", conn);
                    Console.WriteLine("Command is executed:");
                    
                    dr = cmd.ExecuteReader();
                    Console.WriteLine("Data is retriving:");
                    while (dr.Read())
                    {
                        Console.WriteLine($"{dr[0]} {dr[1]} {dr[2]} {dr[3]}");
                    }

                }
                else Console.WriteLine("Product details not inserted");
            }
            catch (Exception product)
            {
                Console.WriteLine($"Error {product.Message}");
            }
            finally
            {
                conn.Close();
            }

        }
    }
}