using CinemaBookingSystem.Logic;
using CinemaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb.Controllers
{
   // private BookingManager manager = new BookingManager();
    public class BookingController : Controller
    {
        private BookingManager manager = new BookingManager();
        private MovieManager movies = new MovieManager();
        public IActionResult Bookings(int? movieId)
        {
            BookingsModel model = new BookingsModel();
            if (movieId.HasValue)
            {
                model.SingleBooking = manager.GetUserBookings(movieId.Value);
                model.Movies = manager.GetUserBookings(movieId).ToList();
                if (true)
                {

                }
            }
            return RedirectToAction(nameof(Bookings));
        }
        
        //public IActionResult Cancelation(int movieId)
        //{
        //    BookingsModel model = new BookingsModel();
        //    model.Movies = bookings.GetUserBookings(movieId).ToList();
        //    return RedirectToAction(nameof(Bookings));
        //}
    }
}
