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
        public Movies GetUserBookings(int movieId)
        {            
            //returns a movie that a client chose
            using (var db = new CinemaDb())
            {
                var movie = db.Movies.FirstOrDefault(m => m.Id == movieId);
                var theater = db.Theaters.FirstOrDefault(t => t.Id == movie.AuditoriumId);
                if (movie != null && theater.TotalSeats > 0)
                {
                    theater.TotalSeats--;
                    db.Bookings.Add(new Bookings()
                    {
                        MovieId = movie.Id,
                        WatchingTime =movie.PlayingTime
                    });
                    
                    db.SaveChanges();
                    return movie;
                }               
               //also need to count down the number of seats available at the auditorium
            }
            return null;
        }

        public Movies CancelUserBookings(int movieId)
        {
            //returns a movie(movies) that was canceled by a client
            using (var db = new CinemaDb())
            {
                var cancelBooking = db.Bookings.FirstOrDefault(m => m.MovieId == movieId);
                if (cancelBooking != null)
                {
                    db.Bookings.Remove(cancelBooking);
                    var cancelation = db.Movies.FirstOrDefault(m => m.Id == movieId);
                    var returnedseat = db.Theaters.FirstOrDefault(t => t.Id == cancelation.AuditoriumId);
                    
                    returnedseat.TotalSeats++;
                    db.SaveChanges();
                    return cancelation;
                }                
            }
            return null;
        }
        
    }
}
