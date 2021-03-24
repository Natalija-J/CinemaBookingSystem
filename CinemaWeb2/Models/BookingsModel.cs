using CinemaBookingSystem.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb2.Models
{
    public class BookingsModel
    {
        public List<Movies> SelectedMovies { get; set; }
        public Movies SelectedMovie { get; set; }

        public List<Bookings> Movies { get; set; }
    }
}
