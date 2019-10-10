using System;

namespace wahalaApI.Models
{
    public class Wahala
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Issue { get; set; }   
        public string  Description { get; set; }
        public string Responsibility { get; set; }
        public string Status { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public string Severity { get; set; }
    }
}