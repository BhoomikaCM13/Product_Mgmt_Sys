using Entity_Layer;
using Product_Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Business.Services
{
    public class ColorService
    {
        IColorRepository _colorRepository;
        public ColorService(IColorRepository colorRepository)
        {
            _colorRepository = colorRepository;
        }
        public void AddColor(Color color)
        {
            _colorRepository.AddColor(color);
        }
        public Color GetColor(Guid id)
        {
            return _colorRepository.GetColor(id);
        }
    }
}
