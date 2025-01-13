using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace HotelBookingApp.Models
{
    public class Room
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string RoomNumber { get; set; } = string.Empty; 
        public string Type { get; set; } = string.Empty; 
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty; 
        public bool IsAvailable { get; set; } = true;
    }
}
