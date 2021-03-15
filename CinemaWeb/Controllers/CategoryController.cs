using CinemaBookingSystem.Logic;
using CinemaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;


namespace CinemaWeb.Controllers
{
    //private CategoryManager manager = new CategoryManager();
    public class CategoryController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            CategoryModel model = new CategoryModel();
            return View(model);
        }
    }

    [HttpPost]
    public IActionResult Create(CategoryModel model)
    {
        if (ModelState.IsValid)
        {

            var result = manager.CreateNew(model.Title);
            if (String.IsNullOrEmpty(result))
            {
                return RedirectToAction("Categories", "Movie");
            }
            else
            {
                ModelState.AddModelError("validation", result);
            }
        }
        return View(model);
    }


}
