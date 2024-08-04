using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Railway_Reservation_System.Models
{
    public class Booking
    {
        [Key]
        public int Booking_Id { get; set; }
        public int Train_No { get; set; }
        public int User_ID { get; set; }
        public int No_of_Tickets { get; set; }
        public DateTime Booking_Date { get; set; }
    }
}
