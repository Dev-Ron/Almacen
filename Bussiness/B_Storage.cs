using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussiness
{
    public class B_Storage
    {
        private EntitiesContext _Context;

        public static List<StorageEntity> StorageList()
        {
            using (var db = new EntitiesContext())
            {
                return db.Storages
                    .Include(s => s.Product)
                    .Include(s => s.WhereHouse)
                    .ToList();
            }
        }

        public static StorageEntity CreateStorage(StorageEntity oStorage)
        {
            using (var db = new EntitiesContext())
            {
                db.Storages.Add(oStorage);
                db.SaveChanges();

                return GetStorageById(oStorage.Id);
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

        public static void UpdateStorage(StorageEntity oStorage)
        {
            oStorage.LasUpdate = DateTime.Now;

            using (var db = new EntitiesContext())
            {
                db.Storages.Update(oStorage);
                db.SaveChanges();
            }
        }
    }
}
