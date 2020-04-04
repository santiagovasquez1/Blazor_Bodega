using DataAcces;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Bussines
{
    public class B_Storage
    {
        public List<StorageEntity> StorageList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList();
            }
        }

        public void CreateStorage(StorageEntity storage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Add(storage);
                db.SaveChanges();
            }
        }

        public void UpdateStorage(StorageEntity storage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Update(storage);
                db.SaveChanges();
            }
        }
    }
}