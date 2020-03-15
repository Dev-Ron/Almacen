using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussiness
{
    public class B_Product
    {
        public List<ProductEntity> ProductList()
        {
            using (var db = new EntitiesContext())
            {
                return db.Products.ToList();
            }
        }

        public void CreateProduct(ProductEntity product)
        {
            using (var db = new EntitiesContext())
            {
                db.Add(product);
                db.SaveChanges();
            }
        }

        public void DeleteProduct(ProductEntity product)
        {
            using (var db = new EntitiesContext())
            {
                db.Remove(product);
                db.SaveChanges();
            }
        }

        public void UpdateProduct(ProductEntity product)
        {
            using (var db = new EntitiesContext())
            {
                db.Update(product);
                db.SaveChanges();
            }
        }
    }
}
