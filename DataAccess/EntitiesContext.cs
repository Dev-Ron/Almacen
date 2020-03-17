using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class EntitiesContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InputOutputEntity> InOuts { get; set; }
        public DbSet<WhereHouseEntity> WhereHouses { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=tcp:ronalservidorestudiante.database.windows.net,1433;Initial Catalog=Project 1;Persist Security Info=False;User ID=rmgelvez;Password=Rm1094277320;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }
    }
}
