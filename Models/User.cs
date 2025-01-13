using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace HotelBookingApp.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty; 
        public string Password { get; set; } = string.Empty; 
        public string Role { get; set; } = string.Empty; 
        public string Email { get; set; } = string.Empty; 
}
