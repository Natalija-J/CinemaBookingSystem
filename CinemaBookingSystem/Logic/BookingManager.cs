using CinemaBookingSystem.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaBookingSystem.Logic
{
    public class BookingManager
    {
        //Movies chosen by title
        public List<Movies> GetAllBookings(string title)
        {
            //returns a movie that a client chose
            using (var db = new CinemaDb())
            {
                var chosenMovie = new MovieManager();
                
                return db.Movies.Where(m => m.Title.ToLower() == title.ToLower()).ToList();
            }
        }
    }
}
