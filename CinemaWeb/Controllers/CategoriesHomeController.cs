using CinemaBookingSystem.Logic;
using CinemaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb.Controllers
{
    public class CategoriesHomeController : Controller
    {
        private CategoryManager categories = new CategoryManager();
        private MovieManager movies = new MovieManager();
        
        public IActionResult Categories(int? id)
        {
            MoviesModel model = new MoviesModel();
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
    }
}
