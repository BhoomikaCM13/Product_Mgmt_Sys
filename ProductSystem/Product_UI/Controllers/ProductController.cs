using Microsoft.AspNetCore.Mvc;

namespace Product_UI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
