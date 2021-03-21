using CinemaBookingSystem;
using CinemaBookingSystem.Logic;
using CinemaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;


namespace CinemaWeb.Controllers
{
   
    public class CategoryController : Controller
    {
        private CategoryManager manager = new CategoryManager();
        [HttpGet]
        public IActionResult Create()
        {
            CategoryModel model = new CategoryModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CategoryModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    manager.CreateNew(model.Title);
                    return RedirectToAction(nameof(Create));
                }

                catch (LogicException ex)
                {
                    ModelState.AddModelError("validation", ex.Message);
                }
                catch (Exception ex)
                {
                    // some other unexpected error
                    ModelState.AddModelError("validation", ex.Message);
                }
            }
            return View(model);
        }
    }

}
