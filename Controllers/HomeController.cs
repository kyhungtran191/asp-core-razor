using Microsoft.AspNetCore.Mvc;

namespace razor_asp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
