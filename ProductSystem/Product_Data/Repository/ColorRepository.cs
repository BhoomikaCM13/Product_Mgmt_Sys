using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Data.Repository
{
    public class ColorRepository : IColorRepository
    {
        ProductDbContext _cdb;

        public ColorRepository(ProductDbContext cdb)
        {
            _cdb = cdb;
        }

        public void AddColor(Color color)
        {
            Guid cId = Guid.NewGuid();
            color.ColorId = cId;
            _cdb.Colors.Add(color);
            _cdb.SaveChanges();
        }

        public Color GetColor(Guid id)
        {
            return _cdb.Colors.Find(id);
        }
    }

}
