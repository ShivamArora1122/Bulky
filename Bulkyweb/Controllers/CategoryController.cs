using Microsoft.AspNetCore.Mvc;

namespace Bulkyweb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
