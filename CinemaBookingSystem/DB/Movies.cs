using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CinemaBookingSystem.DB
{
    public partial class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string MainActor { get; set; }
        public int? Category { get; set; }
        public DateTime PlayingTime { get; set; }
    }
}
