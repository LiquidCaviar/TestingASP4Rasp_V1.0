using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingASP4Rasp_V1._0.Controllers
{
    public class AppController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.title = "Contact Us";

            return View();
        }

        public IActionResult About()
        {
            ViewBag.title = "About";

            return View();
        }
    }
}
