using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussiness
{
    public class B_WhereHouse
    {
        private EntitiesContext _Context;

        public static List<WhereHouseEntity> WherehouseList()
        {
            using (var db = new EntitiesContext())
            {
                return db.WhereHouses.ToList();
            }
        }

        public static void CreateWherehouse(WhereHouseEntity oWarehouse)
        {
            using (var db = new EntitiesContext())
            {
                db.WhereHouses.Add(oWarehouse);
                db.SaveChanges();
            }
        }

        public static void UpdateWherehouse(WhereHouseEntity oWarehouse)
        {
            using (var db = new EntitiesContext())
            {
                db.WhereHouses.Update(oWarehouse);
                db.SaveChanges();
            }
        }
    }
}
