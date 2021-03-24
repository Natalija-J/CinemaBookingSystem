using CinemaBookingSystem.Logic;
using CinemaWeb2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb2.Controllers
{
    public class BookingsController : Controller
    {
        private BookingManager manager = new BookingManager();
        public IActionResult Select(int id)
        {
            BookingsModel model = new BookingsModel();
            model.SelectedMovies = manager.GetUserBookings(id);

            return View(model);
        }

        public IActionResult Cancel(int id)
        {
            manager.CancelUserBookings(id);

            return RedirectToAction(nameof(Select));
        }

        public IActionResult UserMovies()
        {
            var movies = manager.ShowUserBookings();
            return View(movies);
        }
    }
}
