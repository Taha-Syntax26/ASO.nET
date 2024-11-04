using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationtaha.Models;

namespace WebApplicationtaha.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}