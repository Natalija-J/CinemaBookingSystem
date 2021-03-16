using CinemaBookingSystem.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb.Models
{
    public class MoviesModel
    {
        //public List<Movies> Movies { get; set; }
        public Movies ActiveMovie { get; set; }
        public List<Categories> Categories { get; set; }
        public Categories ActiveCategory { get; set; }
        public List<Movies> Movies { get; set; }
        public MoviesModel()
        {

        }
    }
}
