using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussiness
{
    public class B_InputOutput
    {
        public List<InputOutputEntity> InputOutputList()
        {
            using (var db = new EntitiesContext())
            {
                return db.InputOutputs.ToList();
            }
        }

        public void CreateInputOutput(InputOutputEntity inputOutput)
        {
            using (var db = new EntitiesContext())
            {
                db.Add(inputOutput);
                db.SaveChanges();
            }
        }

        public void DeleteInputOutput(InputOutputEntity inputOutput)
        {
            using (var db = new EntitiesContext())
            {
                db.Remove(inputOutput);
                db.SaveChanges();
            }
        }

        public void UpdateInputOutput(InputOutputEntity inputOutput)
        {
            using (var db = new EntitiesContext())
            {
                db.Update(inputOutput);
                db.SaveChanges();
            }
        }
    }
}
