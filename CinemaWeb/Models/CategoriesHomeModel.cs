using CinemaBookingSystem.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb.Models
{
    public class CategoriesHomeModel
    {

        public List<Categories> Categories { get; set; }
        public List<Movies> Movies { get; set; }
       
        public Categories ActiveCategory { get; set; }
        public Bookings Images { get; set; }

    }
}
