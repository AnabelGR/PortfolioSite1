using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public IActionResult GeteRpositories()
        {
            var allRepositories = Repository.GetRepositories();
            return View(allRepositories);
        }
    }
}
