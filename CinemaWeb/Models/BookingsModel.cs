using CinemaBookingSystem.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb.Models
{
    public class BookingsModel
    {
        public List<Movies> Movies { get; set; }
        public List<Bookings> Bookings { get; set; }
        public Movies Movie { get; set; }
    }
}
