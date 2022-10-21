using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Data.Repository
{
    public class SizeRepository : ISizeRepository
    {
       ProductDbContext _sdb;

        public SizeRepository(ProductDbContext sdb)
        {
            _sdb = sdb;
        }

        public void AddSize(Size size)
        {
            Guid sId = Guid.NewGuid();
            size.SizeId = sId;
            _sdb.Sizes.Add(size);
            _sdb.SaveChanges();
        }

        public Size GetSize(Guid id)
        {
            return _sdb.Sizes.Find(id);
        }
    }
}

