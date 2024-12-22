using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TrainReservationSystem
{
    public static class BookingService
    {
        private static string connectionString = "Server=ICS-LT-D244D68Z;Database=TrainReservation;Integrated Security=True;";

        public static void BookTicket()
        {
            try
            {
           
                Console.Write("Enter Source: ");
                string source = Console.ReadLine();
                Console.Write("Enter Destination: ");
                string destination = Console.ReadLine();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("GetTrainsBySourceDestination", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Source", source);
                    command.Parameters.AddWithValue("@Destination", destination);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("\nAvailable Trains for the given Source and Destination:");
                        bool trainsFound = false;

                        while (reader.Read())
                        {
                            trainsFound = true;
                            Console.WriteLine($"Train No: {reader["TrainNo"]}, Name: {reader["TrainName"]}");
                            Console.WriteLine($"Source: {reader["Source"]}, Destination: {reader["Destination"]}");
                            Console.WriteLine($"1A: {reader["Available1A"]}, 2A: {reader["Available2A"]}, Sleeper: {reader["AvailableSleeper"]}");
                            Console.WriteLine("-----------------------------------------------------");
                        }

                        if (!trainsFound)
                        {
                            Console.WriteLine("No trains available for the specified source and destination.");
                            return;
                        }
                    }
                }

           
                Console.Write("Enter Train Number from the above list: ");
                int trainNo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Passenger Name: ");
                string passengerName = Console.ReadLine();
                Console.Write("Enter Class (1A, 2A, Sleeper): ");
                string trainClass = Console.ReadLine();
                Console.Write("Enter Number of Berths to Book: ");
                int berths = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Journey Date (YYYY-MM-DD): ");
                DateTime journeyDate = DateTime.Parse(Console.ReadLine());
                       if (journeyDate<DateTime.Now)
                {
                    Console.WriteLine("Error:You cannot book tickets for a past date.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("BookTicket", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TrainNo", trainNo);
                    command.Parameters.AddWithValue("@PassengerName", passengerName);
                    command.Parameters.AddWithValue("@Class", trainClass);
                    command.Parameters.AddWithValue("@BerthsBooked", berths);
                    command.Parameters.AddWithValue("@JourneyDate", journeyDate);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                        Console.WriteLine("Booking successful.");
                    else
                        Console.WriteLine("Booking failed: Not enough berths available or train not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error booking ticket: {ex.Message}");
            }
        }

        public static void CancelTicket()
        {
            try
            {
                Console.Write("Enter Booking ID to Cancel: ");
                int bookingID = Convert.ToInt32(Console.ReadLine());

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("CancelTicket", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BookingID", bookingID);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                        Console.WriteLine("Cancellation successful.");
                    else
                        Console.WriteLine("Cancellation failed: Invalid Booking ID or booking already cancelled.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error cancelling ticket: {ex.Message}");
            }
        }

        public static void ShowAllTrains()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("ShowAllTrains", connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("\nAvailable Trains:");
                        while (reader.Read())
                        {
                            Console.WriteLine($"Train No: {reader["TrainNo"]}, Name: {reader["TrainName"]}");
                            Console.WriteLine($"Source: {reader["Source"]}, Destination: {reader["Destination"]}");
                            Console.WriteLine($"1A: {reader["Available1A"]}, 2A: {reader["Available2A"]}, Sleeper: {reader["AvailableSleeper"]}");
                            Console.WriteLine("-----------------------------------------------------");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching train details: {ex.Message}");
            }
        }

        public static void ShowAllBookings()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("ShowAllBookings", connection);
                
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("\nBooking Details:");
                        while (reader.Read())
                        {
                            Console.WriteLine($"Booking ID: {reader["BookingID"]}");
                            Console.WriteLine($"Train No: {reader["TrainNo"]}, Passenger: {reader["PassengerName"]}, Class: {reader["Class"]}");
                            Console.WriteLine($"Berths Booked: {reader["BerthsBooked"]}, Journey Date: {reader["JourneyDate"]}, Status: {reader["Status"]}");
                            Console.WriteLine("-----------------------------------------------------");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching bookings: {ex.Message}");
            }
        }
    }
}
