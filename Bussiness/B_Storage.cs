using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussiness
{
    public class B_Storage
    {
        public List<StorageEntity> StorageList()
        {
            using (var db = new EntitiesContext())
            {
                return db.Storages.ToList();
            }
        }

        public void CreateStorage(StorageEntity storage)
        {
            using (var db = new EntitiesContext())
            {
                db.Add(storage);
                db.SaveChanges();
            }
        }

        public void DeleteStorage(StorageEntity storage)
        {
            using (var db = new EntitiesContext())
            {
                db.Remove(storage);
                db.SaveChanges();
            }
        }

        public void UpdateStorage(StorageEntity storage)
        {
            using (var db = new EntitiesContext())
            {
                db.Update(storage);
                db.SaveChanges();
            }
        }
    }
}
