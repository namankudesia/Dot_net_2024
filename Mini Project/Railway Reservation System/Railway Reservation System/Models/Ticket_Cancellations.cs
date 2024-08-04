using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Railway_Reservation_System.Models
{
    public class Ticket_Cancellations
    {
        [Key]
        public int Cancellation_ID { get; set; }
        public int Booking_Id { get; set; }
        public int No_of_Tickets { get; set; }
        public DateTime Cancellation_date { get; set; }
    }
}
