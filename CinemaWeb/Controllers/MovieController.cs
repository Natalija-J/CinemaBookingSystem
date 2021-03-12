using CinemaBookingSystem.Logic;
using CinemaWeb.Models;
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

        public IActionResult Categories(int? id)
        {
            CategoriesModel model = new CategoriesModel();
            model.Categories = categories.GetAllCategories();
            if (id.HasValue)
            {
                //here I am getting one category
                model.ActiveCategory = categories.GetACategory(id.Value);

                //here the movies that are under this category will be displayed
                model.Movies = movies.GetMoviesByCategory(id.Value);
            }
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
