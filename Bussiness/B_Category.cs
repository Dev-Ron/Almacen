using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussiness
{
    public class B_Category
    {

        public static List<CategoryEntity> CategoryList()
        {
            using (var db = new EntitiesContext())
            {
                return db.Categories.ToList();
            }
        }

        public static void CreateCategory(CategoryEntity oCategory)
        {
            using (var db = new EntitiesContext())
            {
                db.Categories.Add(oCategory);
                db.SaveChanges();
            }
        }

        public static void DeleteCategory(CategoryEntity oCategory)
        {
            using (var db = new EntitiesContext())
            {
                db.Categories.Remove(oCategory);
                db.SaveChanges();
            }
        }

        public static void UpdateCategory(CategoryEntity oCategory)
        {
            using (var db = new EntitiesContext())
            {
                db.Categories.Update(oCategory);
                db.SaveChanges();
            }
        }
    }
}