using Microsoft.AspNetCore.Mvc;

namespace FinalProject_ABBOTT.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
