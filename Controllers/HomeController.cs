using Microsoft.AspNetCore.Mvc;

namespace FinalProject_ABBOTT.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

    }
}
