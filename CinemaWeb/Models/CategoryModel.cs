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
       
    }
}
