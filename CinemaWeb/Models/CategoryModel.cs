using CinemaBookingSystem.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb.Models
{
    public class CategoryModel
    {
        [Required]
        [Display(Name = "Category name")]
        public string Title { get; set; }

        [Display(Name = "Category description")]
        public string Description { get; set; }

        // under which category this one should be created
        [Display(Name = "Parent category")]
        public int? ParentCategoryId { get; set; }

        public List<Categories> Categories { get; set; }
    }
}
