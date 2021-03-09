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
        public List<Movies> GetMoviesPlayingToday(int count = 6)
        {
            using (var db = new CinemaDb())
            {
                // SELECT TOP 6 * FROM Movies ORDER BY Playing date - today
                return db.Movies.OrderBy(m => m.PlayingTime ==DateTime.Today).Take(count).ToList();
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
