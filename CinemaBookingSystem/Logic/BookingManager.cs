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
        //gets a list of all movies chosen by the user
        public List<Movies> GetUserBookings(int movieId)
        {            
            //returns a movie that a client chose
            using (var db = new CinemaDb())
            {
                var movie = db.Movies.FirstOrDefault(m => m.Id == movieId);
                var theater = db.Theaters.FirstOrDefault(t => t.Id == movie.AuditoriumId);
                if (movie != null && theater.TotalSeats > 0)
                {
                    //need to count down the number of seats available at the auditorium
                    theater.TotalSeats--;
                    db.Bookings.Add(new Bookings()
                    {   
                        MovieId = movie.Id,
                        WatchingTime =movie.PlayingTime
                    });
                    
                    db.SaveChanges();
                    return db.Movies.OrderBy(c => c.Id).ToList(); 
                }               
               
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

        public List<Movies> ShowUserBookings()
        {
            using (var db = new CinemaDb())
            {
                return db.Movies.OrderBy(m => m.Title).ToList();
            }
        }
        
    }
}
