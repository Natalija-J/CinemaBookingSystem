﻿using CinemaBookingSystem.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaBookingSystem.Logic
{
    public class MovieManager
    {
        //getting movies that are playing now
        public List<Movies> GetMoviesPlayingThisMonth()
        {
                                   
            //var thisWeekStart = baseDate.AddDays(-(int)baseDate.DayOfWeek);
            //var thisWeekEnd = thisWeekStart.AddDays(7).AddSeconds(-1);
           
            //var thisMonthStart = baseDate.AddDays(1 - baseDate.Day);
            //var thisMonthEnd = thisMonthStart.AddMonths(1).AddSeconds(-1);
            
            using (var db = new CinemaDb())
            {
                DateTime today = DateTime.Today;
                var thisMonthStart = today.AddDays(1 - today.Day);
                var thisMonthEnd = thisMonthStart.AddMonths(1).AddSeconds(-1);
                                
                return db.Movies.Where(m => m.PlayingTime >= thisMonthStart && m.PlayingTime <= thisMonthEnd)
                                .OrderBy(m => m.PlayingTime).ToList();
            }
        }
        //get movies by their category
        public List<Movies> GetMoviesByCategory(int category)
        {
            using(var db = new CinemaDb())
            {
                return db.Movies.Where(m => m.Category == category).ToList();
            }
        }
        // getting movies that are coming soon
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
    }
}
