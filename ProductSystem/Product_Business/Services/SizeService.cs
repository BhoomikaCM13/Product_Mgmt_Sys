using Entity_Layer;
using Product_Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Business.Services
{
    public class SizeService
    {
        ISizeRepository _sizeRepository;
        public SizeService(ISizeRepository sizeRepository)
        {
            _sizeRepository = sizeRepository;
        }
        public void AddSize(Size size)
        {
            _sizeRepository.AddSize(size);
        }
        public Size GetSize(Guid id)
        {
            return _sizeRepository.GetSize(id);
        }
    }
}
