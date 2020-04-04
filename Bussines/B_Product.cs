using DataAcces;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Bussines
{
    public class B_Product
    {
        public  List<ProductEntity> ProductList()
        {
            using (var db = new InventaryContext())
            {
                return db.Products.ToList();
            }
        }

        public ProductEntity GetPrductById(string Id)
        {
            using (var db = new InventaryContext())
            {
                return db.Products.ToList().LastOrDefault(x => x.ProductId == Id);
            }
        }

        public  void CreateProduct(ProductEntity product)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Add(product);
                db.SaveChanges();
            }
        }

        public void UpdateProduct(ProductEntity product)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Update(product);
                db.SaveChanges();
            }
        }
    }
}