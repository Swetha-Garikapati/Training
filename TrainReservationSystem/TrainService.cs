using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TrainReservationSystem
{
    public static class TrainService
    {
        private static string connectionString = "Server=ICS-LT-D244D68Z;Database=TrainReservation;Integrated Security=True;";

        public static void AddTrain()
        {
            try
            {
                Console.Write("How many trains do you want to add: ");
                int count = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"\nAdding Train {i + 1}:");
                    Console.Write("Enter Train Number: ");
                    int trainNo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Train Name: ");
                    string trainName = Console.ReadLine();
                    Console.Write("Enter Total Berths for 1A: ");
                    int total1A = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Total Berths for 2A: ");
                    int total2A = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Total Berths for Sleeper: ");
                    int totalSleeper = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Source: ");
                    string source = Console.ReadLine();
                    Console.Write("Enter Destination: ");
                    string destination = Console.ReadLine();

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("AddTrain", connection);
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TrainNo", trainNo);
                        command.Parameters.AddWithValue("@TrainName", trainName);
                        command.Parameters.AddWithValue("@Total1A", total1A);
                        command.Parameters.AddWithValue("@Total2A", total2A);
                        command.Parameters.AddWithValue("@TotalSleeper", totalSleeper);
                        command.Parameters.AddWithValue("@Source", source);
                        command.Parameters.AddWithValue("@Destination", destination);
                        command.ExecuteNonQuery();
                        Console.WriteLine("Train Added Successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void ModifyTrain()
        {
            try
            {
                Console.Write("How many trains do you want to modify: ");
                int count = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"\nModifying Train {i + 1}:");
                    Console.Write("Enter Train Number to Modify: ");
                    int trainNo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter New Train Name: ");
                    string trainName = Console.ReadLine();
                    Console.Write("Enter New Source: ");
                    string source = Console.ReadLine();
                    Console.Write("Enter New Destination: ");
                    string destination = Console.ReadLine();

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("ModifyTrain", connection);
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TrainNo", trainNo);
                        command.Parameters.AddWithValue("@TrainName", trainName);
                        command.Parameters.AddWithValue("@Source", source);
                        command.Parameters.AddWithValue("@Destination", destination);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Train Modified Successfully!");
                        }
                        else
                        {
                            Console.WriteLine("No active train found with that number.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void DeleteTrain()
        {
            try
            {
                Console.Write("How many trains do you want to delete:");
                int count = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"\nDeleting Train {i + 1}:");
                    Console.Write("Enter Train Number to Delete: ");
                    int trainNo = Convert.ToInt32(Console.ReadLine());

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("DeleteTrain", connection);
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TrainNo", trainNo);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Train Deleted Successfully!");
                        }
                        else
                        {
                            Console.WriteLine("No active train found with that number.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}