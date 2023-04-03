using Microsoft.AspNetCore.Mvc;

namespace VisualTypes_Back_Front.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
