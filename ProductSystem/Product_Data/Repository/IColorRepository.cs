using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Data.Repository
{
    public interface IColorRepository
    {
        void AddColor(Color color);
        Color GetColor(Guid id);
    }
}
