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
        public List<Bookings> GetUserBookings(int movieId)
        {            
            //returns a movie that a client chose
            using (var db = new CinemaDb())
            {
                return db.Bookings.Where(m => m.MovieId == movieId).ToList();
            }
        }

        public List<Bookings> CancelUserBookings(int movieId)
        {
            //returns a movie(movies) that was canceled by a client
            using (var db = new CinemaDb())
            {
                return db.Bookings.Remove(m => m.MovieId == movieId).ToList();                    
               
            }
        }

    }
}
