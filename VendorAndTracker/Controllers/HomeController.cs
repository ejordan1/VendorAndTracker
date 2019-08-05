using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace VendorAndTracker.Controllers{
    public class HomeController : Controller {

        [HttpGet("/")]
        public ActionResult Index(){
            Console.WriteLine("HOME CONTROLLER");
            return View();
        }
    }

}