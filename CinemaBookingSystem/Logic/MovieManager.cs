using CinemaBookingSystem.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaBookingSystem.Logic
{
    public class MovieManager
    {
        public List<Movies> GetMovies(int count = 6)
        {
            using (var db = new CinemaDb())
            {
                // SELECT TOP 6 * FROM Articles ORDER BY PublishedOn DESC
                return db.Movies.OrderBy(m => m.PlayingTime).Take(count).ToList();
            }
        }
    }
}
