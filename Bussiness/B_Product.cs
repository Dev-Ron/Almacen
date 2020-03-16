using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussiness
{
    public class B_Product
    {
        public static List<ProductEntity> ProductList()
        {
            using (var db = new EntitiesContext())
            {
                return db.Products.ToList();
            }
        }

        public static void CreateProduct(ProductEntity product)
        {
            using (var db = new EntitiesContext())
            {
                db.Add(product);
                db.SaveChanges();
            }
        }

        public static void DeleteProduct(ProductEntity product)
        {
            using (var db = new EntitiesContext())
            {
                db.Remove(product);
                db.SaveChanges();
            }
        }

        public static void UpdateProduct(ProductEntity product)
        {
            using (var db = new EntitiesContext())
            {
                db.Update(product);
                db.SaveChanges();
            }
        }
    }
}
