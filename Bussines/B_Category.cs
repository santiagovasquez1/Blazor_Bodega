using DataAcces;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Bussines
{
    public class B_Category
    {
        public static List<CategoryEntity> CategoryList()
        {
            using (var db = new InventaryContext())
            {
                return db.Categories.ToList();
            }
        }

        public void CreateCategory(CategoryEntity category)
        {
            using (var db = new InventaryContext())
            {
                db.Categories.Add(category);
                db.SaveChanges();
            }
        }

        public void UpdateCategory(CategoryEntity category)
        {
            using (var db = new InventaryContext())
            {
                db.Categories.Update(category);
                db.SaveChanges();
            }
        }
    }
}