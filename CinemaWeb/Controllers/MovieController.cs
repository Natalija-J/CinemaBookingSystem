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
            
            return View(model);
                       
        }

        public IActionResult MovieCategory(int id)
        {
            MoviesModel model = new MoviesModel();
            model.Categories = categories.GetAllCategories();
            
                //here I am getting one category
            model.ActiveCategory = categories.GetACategory(id);

                //here the movies that are under this category will be displayed
            model.ActiveMovie = movies.GetAMovie(id);
            

            return View(model);

        }


        public IActionResult Movies(int? id)
        {
            MoviesModel model = new MoviesModel();
            model.Categories = categories.GetAllCategories();
            if (id.HasValue)
            {
                //here I am getting one chosen movie
                model.ActiveMovie = movies.GetAMovie(id.Value);
                
            }

            return View(model);            
        }
        

        public IActionResult MoviesThisWeek()
        {
            CategoriesModel model = new CategoriesModel(); 
            model.Movies = movies.GetMoviesPlayingThisWeek();
            return View(model);
        }
        public IActionResult MoviesComingSoon()
        {
            CategoriesModel model = new CategoriesModel();
            model.Movies = movies.GetComingSoonMovies();
            return View(model);
        }

        
        public IActionResult MonthFeatures()
        {
            CategoriesModel model = new CategoriesModel();
            model.Movies = movies.GetMoviesPlayingThisMonth();
            return View(model);
        }

        public IActionResult AllMovies()
        {
            CategoriesModel model = new CategoriesModel();
            model.Movies = movies.GetAllMovies();
            return View(model);
        }
        //public IActionResult Bookings(int movieId)
        //{
        //    BookingsModel model = new BookingsModel();
        //    model.Movies = bookings.GetUserBookings(movieId).ToList();
        //    return RedirectToAction(nameof(Bookings));
        //}
        //public IActionResult Cancelation(int movieId)
        //{
        //    BookingsModel model = new BookingsModel();
        //    model.Movies = bookings.GetUserBookings(movieId).ToList();
        //    return RedirectToAction(nameof(Bookings));
        //}
    }
}
