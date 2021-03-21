using CinemaBookingSystem.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb2.Models
{
    public class MovieModel
    {
        public Movies Movie { get; set; }
        public List<Categories> Categories { get; set; }
        public Categories ActiveCategory { get; set; }

    }
}
