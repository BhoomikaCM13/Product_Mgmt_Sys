using Entity_Layer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product_Business.Services;
using System;

namespace Product_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private ArticleService _artService;
        public ArticleController(ArticleService artService)
        {
            _artService = artService;
        }
        [HttpGet("GetArticle")]
        public Article GetArticleId(Guid id)
        {
            return _artService.GetArticle(id);
        }

        [HttpPost("AddArticle")]
        public IActionResult AddArticle([FromBody] Article art)
        {
            _artService.AddArticle(art);
            return Ok("Entered Successfully!");
        }
    }
}
