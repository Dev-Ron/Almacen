using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussiness
{
    public class B_InputOutput
    {
        private EntitiesContext _Context;

        public static List<InputOutputEntity> OutputList()
        {
            using (var db = new EntitiesContext())
            {
                return db.InOuts.ToList();
            }
        }

        public static void CreateOutput(InputOutputEntity oOutput)
        {
            using (var db = new EntitiesContext())
            {
                db.InOuts.Add(oOutput);
                db.SaveChanges();
            }
        }

        public static void UpdateOutput(InputOutputEntity oOutput)
        {
            using (var db = new EntitiesContext())
            {
                db.InOuts.Update(oOutput);
                db.SaveChanges();
            }
        }
    }
}
