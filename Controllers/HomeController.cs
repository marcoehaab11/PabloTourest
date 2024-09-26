using Microsoft.AspNetCore.Mvc;
using MimeKit;

using System.Diagnostics;
using MailKit.Net.Smtp;


namespace PabloTourest.Controllers
{

    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
         public IActionResult Service()
        {
            return View();
        }
        [HttpGet]
         public IActionResult ContactUs()
        {
            return View();
        }  
        public IActionResult Programs()
        {
            return View();
        }

   
    }


}

