using Entity_Layer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product_Business.Services;
using System;

namespace Product_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SizeController : ControllerBase
    {
        private SizeService _sizeService;
        public SizeController(SizeService sizeService)
        {
            _sizeService = sizeService;
        }
        [HttpGet("GetSize")]
        public Size GetSizeId(Guid id)
        {
            return _sizeService.GetSize(id);
        }

        [HttpPost("AddSize")]
        public IActionResult AddSize([FromBody] Size pro)
        {
            _sizeService.AddSize(pro);
            return Ok("Entered Successfully!");
        }
    }
}
