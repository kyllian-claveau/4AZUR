using Microsoft.AspNetCore.Mvc;

namespace LinkUp.API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}