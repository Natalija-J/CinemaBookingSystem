using CinemaBookingSystem.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb.Models
{
    public class BookingsModel
    {
        public List<Bookings> Movies { get; set; }
        public List<Movies> MoviesExtra { get; set; }
        public List<Bookings> Bookings { get; set; }
        public Movies Movie { get; set; }
        public Bookings SingleBooking { get; set; }
        public Movies Cancel { get; set; }

    }
}
