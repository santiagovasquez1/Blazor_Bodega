using DataAcces;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Bussines
{
    public class B_Warehouse
    {
        public List<warehouseEntity> WarehouseList()
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouses.ToList();
            }
        }

        public void CreateWarehouse(warehouseEntity warehouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Add(warehouse);
                db.SaveChanges();
            }
        }

        public warehouseEntity GetWarehouseById(string id)
        {
            using(var db=new InventaryContext())
            {
                return db.Warehouses.ToList().LastOrDefault(x => x.WarehouseId == id);
            }
        }

        public void UpdateWarehouse(warehouseEntity warehouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Update(warehouse);
                db.SaveChanges();
            }
        }
    }
}