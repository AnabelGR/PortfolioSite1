using Microsoft.AspNetCore.Mvc;


namespace PortfolioDeux.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Bio()
        {
            return View();
        }
        public IActionResult ReferencesCV()
        {
            return View();
        }
        public IActionResult GetInTouch()
        {
            return View();
        }
    }
}
