using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Railway_Reservation_System.Models
{
    public class Train
    {
        [Key]
        public int Train_No { get; set; }
        public string Train_Name { get; set; }
        public string Source_Station { get; set; }
        public string Destination_Station { get; set; }
        public int Price { get; set; }
        public string class_of_travel { get; set; }
        public string train_status { get; set; }
        public int seat_available { get; set; }
    }
}
