using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PortfolioDeux.Models;


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
