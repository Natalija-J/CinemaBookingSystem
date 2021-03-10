﻿using CinemaBookingSystem.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaBookingSystem.Logic
{
    public class CategoryManager
    {
        public List<Categories> GetAllCategories()
        {
            //returns Topics, ordered by Title ASC
            using (var db = new CinemaDb())
            {
                // SELECT * FROM Topics ORDER BY Title
                return db.Categories.OrderBy(c => c.Title).ToList();
            }
        }
    }
}
