using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bussiness
{
    public class B_Category
    {

        public async Task<IEnumerable<CategoryEntity>> CategoryList(CancellationToken ct=default)
        {
            using (var db = new EntitiesContext())
            {
                return await Task.FromResult(db.Categories.ToList());
            }
        }

        public Task CreateCategory(CategoryEntity oCategory)
        {
            using (var db = new EntitiesContext())
            {
                db.Categories.Add(oCategory);
                return Task.FromResult(db.SaveChanges());
            }
        }

        public Task DeleteCategory(CategoryEntity oCategory)
        {
            using (var db = new EntitiesContext())
            {
                db.Categories.Remove(oCategory);
                return Task.FromResult(db.SaveChanges());
            }
        }

        public Task UpdateCategory(CategoryEntity oCategory)
        {
            using (var db = new EntitiesContext())
            {
                db.Categories.Update(oCategory);
                return Task.FromResult(db.SaveChanges());
                
            }
            
        }
    }
}