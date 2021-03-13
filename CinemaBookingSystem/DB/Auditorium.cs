using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CinemaBookingSystem.DB
{
    public partial class Auditorium
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? TotalSeats { get; set; }
        public int? TotalRows { get; set; }
        public int? TotalSeatsInArow { get; set; }
    }
}
