using System.Data.Entity;
using Railway_Reservation_System.Models;

namespace Railway_Reservation_System
{
    public class RailwayContextData : DbContext
    {
        public RailwayContextData() : base("name=Train_Reservation")
        {
        }
        public DbSet<Train> Trains { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Ticket_Cancellations> TicketCancellations { get; set; }
    }
}