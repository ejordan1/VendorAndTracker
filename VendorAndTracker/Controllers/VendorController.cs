using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VendorAndTracker.Models;
namespace VendorAndTracker.Controllers{

class VendorController : Controller{
    public ActionResult Index(){
            return View(Vendor._allVendors);
        }
    }
}