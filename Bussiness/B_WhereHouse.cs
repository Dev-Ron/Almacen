using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussiness
{
    public class B_WhereHouse
    {
        public List<WhereHouseEntity> WhereHouseList()
        {
            using (var db = new EntitiesContext())
            {
                return db.WhereHouses.ToList();
            }
        }

        public void CreateWhereHouse(WhereHouseEntity whereHouse)
        {
            using (var db = new EntitiesContext())
            {
                db.Add(whereHouse);
                db.SaveChanges();
            }
        }

        public void DeleteWhereHouse(WhereHouseEntity whereHouse)
        {
            using (var db = new EntitiesContext())
            {
                db.Remove(whereHouse);
                db.SaveChanges();
            }
        }

        public void UpdateWhereHouse(WhereHouseEntity whereHouse)
        {
            using (var db = new EntitiesContext())
            {
                db.Update(whereHouse);
                db.SaveChanges();
            }
        }
    }
}
