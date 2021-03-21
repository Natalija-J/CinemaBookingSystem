using CinemaBookingSystem.Logic;
using CinemaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb.Controllers
{
   
    public class BookingController : Controller
    {
        private BookingManager manager = new BookingManager();
        private MovieManager movies = new MovieManager();
        public IActionResult Bookings(int? movieId)
        {
            BookingsModel model = new BookingsModel();
            MoviesModel moviesM = new MoviesModel();
            
                model.Movies = manager.GetUserBookings(movieId.Value);
            
            return RedirectToAction(nameof(Bookings));
        }

        public IActionResult Cancel(int movieId)
        {
            BookingsModel model = new BookingsModel();
            model.Cancel = manager.CancelUserBookings(movieId);
             return RedirectToAction(nameof(Bookings));
        }


    }
}
