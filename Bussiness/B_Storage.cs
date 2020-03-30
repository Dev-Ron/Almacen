using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bussiness
{
    public class B_Storage
    {
        public static List<StorageEntity> StorageList()
        {
            using (var db = new EntitiesContext())
            {
                return db.Storages.ToList();
            }
        }

        public async Task<IEnumerable<StorageEntity>> StorageList(CancellationToken ct = default)
        {
            using (var db = new EntitiesContext())
            {
                return await Task.FromResult(db.Storages.Include(s => s.WhereHouse).Include(s => s.Product).ToList());
            }
        }


        public Task CreateStorage(StorageEntity oStorage)
        {
            using (var db = new EntitiesContext())
            {
                oStorage.Product = oStorage.Product == null ? null : db.Products.Find(oStorage.Product.Id);
                oStorage.WhereHouse = oStorage.WhereHouse == null ? null : db.WhereHouses.Find(oStorage.WhereHouse.Id);
                db.Storages.Add(oStorage);
                return Task.FromResult(db.SaveChanges());
            }
        }

        /* NUEVO MÉTODO */
        public static StorageEntity GetStorageById(int id)
        {
            using (var db = new EntitiesContext())
            {
                return db.Storages
                    .Include(s => s.Product)
                    .Include(s => s.WhereHouse)
                    .ToList()
                    .LastOrDefault(s => s.Id == id);
            }
        }

        /* NUEVO MÉTODO */
        public static bool IsProductInWarehouse(int id)
        {
            using (var db = new EntitiesContext())
            {
                var product = db.Storages.ToList()
                    .Where(p => p.Id == id);

                return product.Any();
            }
        }

        /* NUEVO MÉTODO */
        public static List<StorageEntity> StorageListByWarehouse(string idWarehouse)
        {
            using (var db = new EntitiesContext())
            {
                return db.Storages
                    .Include(s => s.Product)
                    .Include(s => s.WhereHouse)
                    .Where(s => s.WhereHouse.Name == idWarehouse)
                    .ToList();
            }
        }

        public Task UpdateStorage(StorageEntity oStorage)
        {
            oStorage.LasUpdate = DateTime.Now;

            using (var db = new EntitiesContext())
            {
                db.Storages.Update(oStorage);
                return Task.FromResult(db.SaveChanges());
            }
        }

        public Task DeleteStorage(StorageEntity oStorage)
        {
            oStorage.LasUpdate = DateTime.Now;

            using (var db = new EntitiesContext())
            {
                db.Storages.Remove(oStorage);
                return Task.FromResult(db.SaveChanges());
            }
        }
    }
}
