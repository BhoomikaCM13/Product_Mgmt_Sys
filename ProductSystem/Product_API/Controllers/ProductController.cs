using Entity_Layer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Product_Business.Services;
using System;

namespace Product_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductService _proService;
        public ProductController(ProductService proService)
        {
            _proService = proService;
        }   
        [HttpGet("GetProduct")]
        public Product GetProductId(Guid id)
        {
            return _proService.GetProduct(id);
        }

        [HttpPost("AddProduct")]
        public IActionResult Addproduct([FromBody] Product pro)
        {
            _proService.AddProduct(pro);
            return Ok("Entered Successfully!");
        }
    }
}
