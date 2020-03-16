using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class EntitiesContext : DbContext
    {
        
        public EntitiesContext(DbContextOptions<EntitiesContext> options): base(options)
        { 

        }

        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InputOutputEntity> InputOutputs { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }
        public DbSet<WhereHouseEntity> WhereHouses { get; set; }

    }
}
