using CinemaBookingSystem.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaBookingSystem.Logic
{
    public class MovieManager
    {
        //getting movies that are playing now
        public List<Movies> GetMoviesPlayingThisWeek()
        {
            using (var db = new CinemaDb())
            {
                DateTime today = DateTime.Today;
                DateTime week = today.AddDays(7);
                                
                return db.Movies.Where(m => m.PlayingTime == week)
                                .OrderByDescending(m => m.Title).ToList();
            }
        }
        //get movies by their category
        public List<Movies> GetMoviesByCategory(string category)
        {
            using(var db = new CinemaDb())
            {
                return db.Movies.Where(m => m.Category.ToLower() == category.ToLower()).ToList();
            }
        }
        // getting movies that are coming soon
        //public List<Movies> GetComingSoonMovies()
        //{
        //    using(var db = new CinemaDb())
        //    {
        //        return db.Movies.Where(m => m.PlayingTime < DateTime.Today()).ToList();
        //    }
        //}
    }
}
