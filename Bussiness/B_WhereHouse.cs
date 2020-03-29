using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bussiness
{
    public class B_WhereHouse
    {
        
        public static List<WhereHouseEntity> WherehouseList()
        {
            using (var db = new EntitiesContext())
            {
                return db.WhereHouses.ToList();
            }
        }

        public async Task<IEnumerable<WhereHouseEntity>> WhereHouseList(CancellationToken ct = default)
        {
            using (var db = new EntitiesContext())
            {
                return await Task.FromResult(db.WhereHouses.ToList());
            }
        }


        public Task CreateWherehouse(WhereHouseEntity oWarehouse)
        {
            using (var db = new EntitiesContext())
            {
                db.WhereHouses.Add(oWarehouse);
                return Task.FromResult(db.SaveChanges());
            }
        }

        public Task UpdateWherehouse(WhereHouseEntity oWarehouse)
        {
            using (var db = new EntitiesContext())
            {
                db.WhereHouses.Update(oWarehouse);
                return Task.FromResult(db.SaveChanges());
            }
        }

        public Task DeleteWhereHouse(WhereHouseEntity oCategory)
        {
            using (var db = new EntitiesContext())
            {
                db.WhereHouses.Remove(oCategory);
                return Task.FromResult(db.SaveChanges());

            }

        }
    }
}
