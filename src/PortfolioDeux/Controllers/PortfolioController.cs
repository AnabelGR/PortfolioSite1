using Microsoft.AspNetCore.Mvc;
using PortfolioDeux.Models;

namespace PortfolioDeux.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Design()
        {
            return View();
        }
        public IActionResult WebDesign()
        {
            return View();
        }
        public IActionResult Projects()
        {
            return View();
        }
        public IActionResult Illustration()
        {
            return View();
        }
        public IActionResult GetRepos()
        {
            var allRepos = Repo.GetRepos();
            return View(allRepos);
        }
    }
}
