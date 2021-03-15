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
        public IActionResult Bookings()
        {
            BookingsModel model = new BookingsModel();
           // model.Bookings = manager.GetUserBookings();
            return View(model);
        }
    }
}
