using CinemaBookingSystem.Logic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb.Controllers
{
    public class MovieController : Controller
    {
        private CategoryManager categories = new CategoryManager();
        private MovieManager movies = new MovieManager();
        private BookingManager bookings = new BookingManager();

        public IActionResult Categories()
        {
            var info = categories.GetAllCategories();
            return View(info);
        }

        public IActionResult Movies()
        {
            var info = movies.GetMoviesPlayingThisMonth();
            return View(info);
        }

        public IActionResult MoviesThisWeek()
        {
            var info = movies.GetMoviesPlayingThisWeek();
            return View(info);
        }
        public IActionResult MoviesComingSoon()
        {
            var info = movies.GetComingSoonMovies();
            return View(info);
        }

        public IActionResult Bookings(int movieId)
        {
            var info = bookings.GetUserBookings(movieId);
            return View(info);
        }
    }
}
