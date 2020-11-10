using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingASP4Rasp_V1._0.Services;
using TestingASP4Rasp_V1._0.ViewModels;

namespace TestingASP4Rasp_V1._0.Controllers
{
    public class AppController:Controller
    {
        IMailService _mailService;
        public AppController(IMailService mailService)
        {
            _mailService = mailService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("Contact")]
        public IActionResult Contact()
        { 
            return View();
        }
        [HttpPost("Contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                _mailService.SendMessage("something@mail.mail", model.Subject,model.Message);
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            } 
            return View();
        }

        [HttpGet("About")]
        public IActionResult About()
        {
            ViewBag.title = "About";

            return View();
        }
    }
}
