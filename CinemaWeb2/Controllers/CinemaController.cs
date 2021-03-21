using CinemaBookingSystem.Logic;
using CinemaWeb2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb2.Controllers
{
    public class CinemaController : Controller
    {
        private MovieManager manager = new MovieManager();
        private CategoryManager catmanager = new CategoryManager();
        public IActionResult SingleMovie(int? id)
        {
            MovieModel model = new MovieModel();
            model.Categories = catmanager.GetAllCategories();

            if (id.HasValue)
            {
                model.Movie = manager.GetAMovie(id.Value);
                
                model.ActiveCategory = catmanager.GetACategory(model.Movie.Category);

            }
            return View(model);
        }

        public IActionResult Categories(int? id)
        {
            CategoriesModel model = new CategoriesModel();
            model.Categories = catmanager.GetAllCategories();
            if (id.HasValue)
            {
                model.ActiveCategory = catmanager.GetACategory(id.Value);
                model.Movies = manager.GetMoviesByCategory(id.Value);
            }
            return View(model);
        }

        public IActionResult ComingSoon()
        {
           var movies = manager.GetComingSoonMovies();
            
            return View(movies);
        }
    }
}
