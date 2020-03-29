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
    public class B_InputOutput
    {
        public static List<InputOutputEntity> OutputList()
        {
            using (var db = new EntitiesContext())
            {
                return db.InOuts.Include(s => s.Storage).ToList();
            }
        }

        public async Task<IEnumerable<InputOutputEntity>> InputOutputList(CancellationToken ct = default)
        {
            using (var db = new EntitiesContext())
            {
                return await Task.FromResult(db.InOuts.Include(s => s.Storage).ToList());
            }
        }

        public Task CreateOutput(InputOutputEntity oOutput)
        {
            using (var db = new EntitiesContext())
            {
                db.InOuts.Add(oOutput);
                return Task.FromResult(db.SaveChanges());
            }
        }

        public Task UpdateInputOutput(InputOutputEntity oOutput)
        {
            using (var db = new EntitiesContext())
            {
                db.InOuts.Update(oOutput);
                return Task.FromResult(db.SaveChanges());
            }
        }

        public Task DeleteInputOutput(InputOutputEntity oOutput)
        {
            using (var db = new EntitiesContext())
            {
                db.InOuts.Remove(oOutput);
                return Task.FromResult(db.SaveChanges());
            }
        }
    }
}
