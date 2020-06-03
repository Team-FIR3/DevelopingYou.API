using Microsoft.AspNetCore.Mvc;

namespace DevelopingYou.API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}