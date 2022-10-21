using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Entity_Layer;

namespace Product_Data.Repository
{
    public class ProductRepository : IProductRepository
    {
       ProductDbContext _db;

       public ProductRepository(ProductDbContext db)
        {
            _db = db;
        }

        public void AddProduct(Product product)
        {
            Guid pid = Guid.NewGuid();
            product.ProductId = pid;
            _db.Products.Add(product);
            _db.SaveChanges();
        }

        public Product GetProduct(Guid id)
        {
            return _db.Products.Find(id);
        }
    }
}
