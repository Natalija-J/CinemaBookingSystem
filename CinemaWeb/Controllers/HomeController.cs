using CinemaBookingSystem.Logic;
using CinemaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb.Controllers
{
    public class HomeController : Controller
    {
        private MovieManager manager = new MovieManager();
        private CategoryManager manager1 = new CategoryManager();
        public IActionResult Index()
        {
            //MoviesModel model = new MoviesModel();
            CategoriesModel model = new CategoriesModel();
            model.Movies = manager.GetComingSoonMovies();
            return View(model);
        }

        public IActionResult ContactUs()
        {
            return View();
        }        
    }
}
