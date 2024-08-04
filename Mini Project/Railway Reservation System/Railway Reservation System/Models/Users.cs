using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Railway_Reservation_System.Models
{
    public class Users
    {
        [Key]
        public int User_ID { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
        public string role { get; set; }
    }
}
