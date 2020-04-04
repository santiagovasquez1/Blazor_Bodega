using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAcces
{
    public class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<warehouseEntity> Warehouses { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }
        public DbSet<InputOutputEntity> InputOutputs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConectionString = $"Server = localhost; Database = Inventory; Uid = root; Pwd = Bucefalo_1205";

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(ConectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Estructuracion de base datos

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = "ASH", CategoryName = "Aseo Hogar" },
                new CategoryEntity { CategoryId = "ASP", CategoryName = "Aseo Personal" },
                new CategoryEntity { CategoryId = "HGR", CategoryName = "Hogar" },
                new CategoryEntity { CategoryId = "PRF", CategoryName = "Perfumeria" },
                new CategoryEntity { CategoryId = "SLD", CategoryName = "Salud" },
                new CategoryEntity { CategoryId = "VDJ", CategoryName = "Video Juegos" }
                );

            modelBuilder.Entity<warehouseEntity>().HasData(
                new warehouseEntity()
                {
                    WarehouseId = Guid.NewGuid().ToString(),
                    WarehouseName = "Bodega Central",
                    WarehouseDress = "932 Pallet Street, La Grange (Dutchess), NY 12540"
                },
                new warehouseEntity()
                {
                    WarehouseId = Guid.NewGuid().ToString(),
                    WarehouseName = "Bodega Norte",
                    WarehouseDress = "4447 Dane Street, Yakima, WA 98908"
                },
                new warehouseEntity()
                {
                    WarehouseId = Guid.NewGuid().ToString(),
                    WarehouseName = "Bodega Sur",
                    WarehouseDress = "3003 Arrowood Drive, Jacksonville, FL 32257"
                }
                );
        }
    }
}