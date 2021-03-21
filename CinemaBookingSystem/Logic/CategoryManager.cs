using CinemaBookingSystem.DB;
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

        public Categories GetACategory(int id)
        {
            using (var db = new CinemaDb())
            {
                return db.Categories.FirstOrDefault(c => c.Id == id);
            }
        }

        public string CreateNew(string title)
        {
            using (var db = new CinemaDb())
            {
               
                    db.Categories.Add(new Categories()
                    {
                        Title = title,
                    });

                    db.SaveChanges();
                
                return null;
            }
        }

        //to delete a category
        public void Delete(int id)
        {
            using (var db = new CinemaDb())
            {
                var category = db.Categories.FirstOrDefault(c => c.Id == id);
                db.Categories.Remove(category);

                db.SaveChanges();
            }

        }
    }
}
