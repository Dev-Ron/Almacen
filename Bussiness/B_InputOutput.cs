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
                return await Task.FromResult(db.InOuts
                    .Include(s => s.Storage)
                    .Include(s => s.Storage.Product)
                    .Include(s => s.Storage.WhereHouse)
                    .ToList());
            }
        }

        public Task CreateOutput(InputOutputEntity oOutput)
        {
            using (var db = new EntitiesContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    if (oOutput.WhereHouse != null && oOutput.Product != null)
                    {
                        if (db.Storages.Any(s => s.Product.Id == oOutput.Product.Id && s.WhereHouse.Id == oOutput.WhereHouse.Id))
                        {
                            oOutput.Storage = db.Storages.Where(s => s.Product.Id == oOutput.Product.Id && s.WhereHouse.Id == oOutput.WhereHouse.Id).FirstOrDefault();
                            oOutput.Storage.PartialQuantity = oOutput.IsInput == true ? oOutput.Storage.PartialQuantity + oOutput.Quantity : oOutput.Storage.PartialQuantity - oOutput.Quantity;
                            db.Storages.Update(oOutput.Storage);
                            db.SaveChanges();
                        }
                        else
                        {
                            StorageEntity storageEntity = new StorageEntity()
                            {
                                LasUpdate = DateTime.Now,
                                PartialQuantity = oOutput.Quantity,
                                Product = db.Products.Find(oOutput.Product.Id),
                                WhereHouse = db.WhereHouses.Find(oOutput.WhereHouse.Id)
                            };
                            db.Storages.Add(storageEntity);
                            db.SaveChanges();
                            oOutput.Storage = storageEntity;
                        }
                    }
                    oOutput.Storage = oOutput.Storage == null ? null : db.Storages.Find(oOutput.Storage.Id);
                    db.InOuts.Add(oOutput);
                    db.SaveChanges();
                    transaction.Commit();
                }
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
