using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussiness
{
    public class B_Category
    {
        public List<CategoryEntity> CategoriesList()
        {
            using (var db = new EntitiesContext())
            {
                return db.Categories.ToList();
            }
        }

        public void CreateCategory(CategoryEntity category)
        {
            using (var db = new EntitiesContext())
            {
                db.Add(category);
                db.SaveChanges();
            }
        }

        public void DeleteCategory(CategoryEntity category)
        {
            using (var db = new EntitiesContext())
            {
                db.Remove(category);
                db.SaveChanges();
            }
        }

        public void UpdateCategory(CategoryEntity category)
        {
            using (var db = new EntitiesContext())
            {
                db.Update(category);
                db.SaveChanges();
            }
        }
    }
}
