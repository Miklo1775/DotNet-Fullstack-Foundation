using Microsoft.AspNetCore.Mvc;

namespace ASPNETDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
