using Microsoft.AspNetCore.Mvc;

namespace PracticFrontBack.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
