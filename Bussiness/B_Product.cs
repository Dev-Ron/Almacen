using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bussiness
{
    public class B_Product
    {
        public async Task<IEnumerable<ProductEntity>> ProductList(CancellationToken ct = default)
        {
            using (var db = new EntitiesContext())
            {
                return await Task.FromResult(db.Products.ToList());
            }
        }

        public Task CreateProduct(ProductEntity oProduct)
        {
            using (var db = new EntitiesContext())
            {
                oProduct.CategoryEntity = oProduct.CategoryEntity == null ? null : db.Categories.Find(oProduct.CategoryEntity.Id);
                db.Products.Add(oProduct);
                return Task.FromResult(db.SaveChanges());
            }
        }

        public Task DeleteProduct(ProductEntity oProduct)
        {
            using (var db = new EntitiesContext())
            {
                db.Products.Remove(oProduct);
                return Task.FromResult(db.SaveChanges());
            }
        }

        public Task UpdateProduct(ProductEntity oProduct)
        {
            using (var db = new EntitiesContext())
            {
                db.Products.Update(oProduct);
                return Task.FromResult(db.SaveChanges());

            }

        }
    }
}
