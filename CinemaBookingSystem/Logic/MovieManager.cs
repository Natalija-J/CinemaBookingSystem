using CinemaBookingSystem.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaBookingSystem.Logic
{
       public class MovieManager
       {
            //the list of all movies playing in the theater
            public List<Movies> GetAllMovies()
            {
                using (var db = new CinemaDb())
                {
                    return db.Movies.OrderBy(m => m.Title)
                                    .ToList();
                }
            }

        //getting movies that are playing this month
            public List<Movies> GetMoviesPlayingThisMonth()
            {
                    using (var db = new CinemaDb())
                    {
                        DateTime today = DateTime.Today;
                        var thisMonthStart = today.AddDays(1 - today.Day);
                        var thisMonthEnd = thisMonthStart.AddMonths(1).AddSeconds(-1);

                        return db.Movies.Where(m => m.PlayingTime >= thisMonthStart && m.PlayingTime <= thisMonthEnd)
                                        .OrderBy(m => m.PlayingTime).ToList();
                    }
            }

            public List<Movies> GetMoviesPlayingThisWeek()
            {
                using (var db = new CinemaDb())
                {
                    DateTime today = DateTime.Today;
                    var thisWeekStart = today.AddDays(-(int)today.DayOfWeek);
                    var thisWeekEnd = today.AddDays(7).AddSeconds(-1);

                    return db.Movies.Where(m => m.PlayingTime >= thisWeekStart && m.PlayingTime <= thisWeekEnd)
                                    .OrderBy(m => m.PlayingTime).ToList();
                }
            }
            
            //get movies by their category
            public List<Movies> GetMoviesByCategory(int category)
            {
                    using (var db = new CinemaDb())
                    {
                        return db.Movies.Where(m => m.Category == category).ToList();
                    }
             }

            //getting movies that are coming soon
            public List<Movies> GetComingSoonMovies()
            {
                using (var db = new CinemaDb())
                {
                    DateTime today = DateTime.Today;
                    var nextMonthStart = today.AddMonths(1).AddSeconds(1);
                    var nextMonthEnd = nextMonthStart.AddMonths(1).AddSeconds(-1);

                    return db.Movies.Where(m => m.PlayingTime > nextMonthStart)
                                    .OrderBy(m => m.PlayingTime)
                                    .ToList();
                }
            }

                        

            public Movies GetAMovie(int id)
            {
                using (var db = new CinemaDb())
                {
                    return db.Movies.FirstOrDefault(c => c.Id == id);
                }
            }

            public string CreateNewMovie(string title, string director, string description, int categoryId, int price, int? auditorium, int? length)
            {
                using (var db = new CinemaDb())
                {

                    db.Movies.Add(new Movies()
                    {
                        Title = title,
                        Director = director,
                        PlayingTime = DateTime.Now,
                        TextAbout = description,                        
                        Category = categoryId,
                        PriceId = price,
                        AuditoriumId = auditorium,
                        Length = length,
                        Image = "",
                    });

                    db.SaveChanges();

                    return null;
                }
            }

            public void Delete(int id)
            {
                using(var db = new CinemaDb())
                {
                    var movie = db.Movies.FirstOrDefault(m => m.Id == id);
                    db.Movies.Remove(movie);

                    db.SaveChanges();
                }

            }

       }
}
