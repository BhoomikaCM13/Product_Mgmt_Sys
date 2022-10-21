using Entity_Layer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product_Business.Services;
using System;

namespace Product_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorController : ControllerBase
    {
        private ColorService _colService;
        public ColorController(ColorService colService)
        {
            _colService = colService;
        }
        [HttpGet("GetColor")]
        public Color GetColorId(Guid id)
        {
            return _colService.GetColor(id);
        }

        [HttpPost("AddColor")]
        public IActionResult Addcolor([FromBody] Color pro)
        {
            _colService.AddColor(pro);
            return Ok("Entered Successfully!");
        }
    }
}
