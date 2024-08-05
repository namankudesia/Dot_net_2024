using System;
using System.Linq;
using Railway_Reservation_System.Models;

namespace Railway_Reservation_System
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new RailwayContextData())
            {
                while (true)
                {
                    Console.WriteLine("1. Admin Login");
                    Console.WriteLine("2. User Login");
                    Console.WriteLine("3. Exit");
                    Console.Write("Select an option: ");
                    var option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            AdminLogin(context);
                            break;
                        case "2":
                            UserLogin(context);
                            break;
                        case "3":
                            return;
                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                }
            }
        }
        static void AdminLogin(RailwayContextData context)
        {
            Console.Write("Enter username: ");
            var username = Console.ReadLine();
            Console.Write("Enter password: ");
            var password = Console.ReadLine();

            var user = context.Users.FirstOrDefault(u => u.User_Name == username && u.Password == password && u.role == "admin");

            if (user != null)
            {
                while (true)
                {
                    Console.WriteLine("1. Add New Train");
                    Console.WriteLine("2. View All Trains");
                    Console.WriteLine("3. View Bookings");
                    Console.WriteLine("4. View Cancellations");
                    Console.WriteLine("5. Logout");
                    Console.Write("Select an option: ");
                    var option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            AddNewTrain(context);
                            break;
                        case "2":
                            ViewAllTrains(context);
                            break;
                        case "3":
                            ViewBookings(context);
                            break;
                        case "4":
                            ViewCancellations(context);
                            break;
                        case "5":
                            return;
                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid credentials.");
            }
        }
        static void UserLogin(RailwayContextData context)
        {
            Console.Write("Enter username: ");
            var username = Console.ReadLine();
            Console.Write("Enter password: ");
            var password = Console.ReadLine();
            var user = context.Users.FirstOrDefault(u => u.User_Name == username && u.Password == password && u.role == "user");
            if (user != null)
            {
                while (true)
                {
                    Console.WriteLine("1. Check Train Availability");
                    Console.WriteLine("2. Book Tickets");
                    Console.WriteLine("3. Cancel Tickets");
                    Console.WriteLine("4. Logout");
                    Console.Write("Select an option: ");
                    var option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            CheckTrainAvailability(context);
                            break;
                        case "2":
                            BookTickets(context, user.User_ID);
                            break;
                        case "3":
                            CancelTickets(context, user.User_ID);
                            break;
                        case "4":
                            return;
                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid credentials.");
            }
        }
        static void ViewAllTrains(RailwayContextData context)
        {
            var trains = context.Trains.ToList();
            foreach (var train in trains)
            {
                Console.WriteLine($"Train No: {train.Train_No}, Train Name: {train.Train_Name}, Source: {train.Source_Station}, Destination: {train.Destination_Station}, Price: {train.Price}, Class: {train.class_of_travel}, Status: {train.train_status}, Seats Available: {train.seat_available}");
            }
        }
        public static void AddNewTrain(RailwayContextData context)
        {
            Console.Write("Enter Train Number: ");
            int trainNo;
            if (!int.TryParse(Console.ReadLine(), out trainNo) || trainNo <= 0)
            {
                Console.WriteLine("Invalid Train Number");
                return;
            }
            Console.Write("Enter Train Name: ");
            string trainName = Console.ReadLine();
            Console.Write("Enter Source Station: ");
            string sourceStation = Console.ReadLine();
            Console.Write("Enter Destination Station: ");
            string destinationStation = Console.ReadLine();
            Console.Write("Enter Price: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Enter Class of Travel: ");
            string classOfTravel = Console.ReadLine();
            Console.Write("Enter Train Status: ");
            string trainStatus = Console.ReadLine();
            Console.Write("Enter Seats Available: ");
            int seatsAvailable = int.Parse(Console.ReadLine());
            var newTrain = new Train
            {
                Train_No = trainNo,
                Train_Name = trainName,
                Source_Station = sourceStation,
                Destination_Station = destinationStation,
                Price = price,
                class_of_travel = classOfTravel,
                train_status = trainStatus,
                seat_available = seatsAvailable
            };
            context.Trains.Add(newTrain);
            context.SaveChanges();

            Console.WriteLine("New train added successfully.");
        }
        static void ViewBookings(RailwayContextData context)
        {
            var bookings = context.Bookings.ToList();
            foreach (var booking in bookings)
            {
                Console.WriteLine($"Booking ID: {booking.Booking_Id}, Train No: {booking.Train_No}, User ID: {booking.User_ID}, No of Tickets: {booking.No_of_Tickets}, Date: {booking.Booking_Date}");
            }
        }
        static void ViewCancellations(RailwayContextData context)
        {
            var cancellations = context.TicketCancellations.ToList();
            foreach (var cancellation in cancellations)
            {
                Console.WriteLine($"Cancellation ID: {cancellation.Cancellation_ID}, Booking ID: {cancellation.Booking_Id}, No of Tickets: {cancellation.No_of_Tickets}, Date: {cancellation.Cancellation_date}");
            }
        }
        static void CheckTrainAvailability(RailwayContextData context)
        {
            Console.Write("Enter Train Number: ");
            int trainNo = int.Parse(Console.ReadLine());

            var train = context.Trains.FirstOrDefault(t => t.Train_No == trainNo && t.train_status == "active");

            if (train != null)
            {
                Console.WriteLine($"Train No: {train.Train_No}, Train Name: {train.Train_Name}, Source: {train.Source_Station}, Destination: {train.Destination_Station}, Price: {train.Price}, Class: {train.class_of_travel}, Seats Available: {train.seat_available}");
            }
            else
            {
                Console.WriteLine("Train not found or inactive.");
            }
        }
        static void BookTickets(RailwayContextData context, int userId)
        {
            Console.Write("Enter Train Number: ");
            int trainNo = int.Parse(Console.ReadLine());
            var train = context.Trains.FirstOrDefault(t => t.Train_No == trainNo && t.train_status == "active");
            if (train == null)
            {
                Console.WriteLine("Invalid or inactive train.");
                return;
            }
            Console.Write("Enter Number of Tickets: ");
            int noOfTickets = int.Parse(Console.ReadLine());
            if (noOfTickets < 1 || noOfTickets > 3)
            {
                Console.WriteLine("You can book a maximum of 3 tickets.");
                return;
            }
            if (train.seat_available < noOfTickets)
            {
                Console.WriteLine("Not enough seats available.");
                return;
            }
            var booking = new Booking
            {
                Train_No = trainNo,
                User_ID = userId,
                No_of_Tickets = noOfTickets,
                Booking_Date = DateTime.Now
            };
            context.Bookings.Add(booking);
            train.seat_available -= noOfTickets;
            context.SaveChanges();
            Console.WriteLine("Booking successful!");
        }
        static void CancelTickets(RailwayContextData context, int userId)
        {
            Console.Write("Enter Booking ID: ");
            int bookingId = int.Parse(Console.ReadLine());
            var booking = context.Bookings.FirstOrDefault(b => b.Booking_Id == bookingId && b.User_ID == userId);

            if (booking == null)
            {
                Console.WriteLine("Invalid booking ID.");
                return;
            }
            Console.Write("Enter Number of Tickets to Cancel: ");
            int noOfTickets = int.Parse(Console.ReadLine());
            if (noOfTickets < 1 || noOfTickets > booking.No_of_Tickets)
            {
                Console.WriteLine("Invalid number of tickets.");
                return;
            }
            var cancellation = new Ticket_Cancellations
            {
                Booking_Id = bookingId,
                No_of_Tickets = noOfTickets,
                Cancellation_date = DateTime.Now
            };
            context.TicketCancellations.Add(cancellation);
            booking.No_of_Tickets -= noOfTickets;
            if (booking.No_of_Tickets == 0)
            {
                context.Bookings.Remove(booking);
            }
            var train = context.Trains.FirstOrDefault(t => t.Train_No == booking.Train_No);
            if (train != null)
            {
                train.seat_available += noOfTickets;
            }
            context.SaveChanges();
            Console.WriteLine("Cancellation successful!");
        }
    }
}