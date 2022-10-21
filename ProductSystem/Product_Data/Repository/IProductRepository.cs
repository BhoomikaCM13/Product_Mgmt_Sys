using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Data.Repository
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        Product GetProduct(Guid id);
    }
}
