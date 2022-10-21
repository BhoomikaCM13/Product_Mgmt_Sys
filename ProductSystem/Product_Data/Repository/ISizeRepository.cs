using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Data.Repository
{
    public interface ISizeRepository
    {
        void AddSize(Size size);
        Size GetSize(Guid id);
    }
}
