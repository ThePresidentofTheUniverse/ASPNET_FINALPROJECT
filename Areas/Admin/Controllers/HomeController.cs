using Microsoft.AspNetCore.Mvc;

namespace FinalProject_ABBOTT.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SummaryPage()
        {
            return View();
        }
    }
}
