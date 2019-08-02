using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VendorAndTracker.Models;
namespace VendorAndTracker.Controllers{

    class VendorController : Controller{

        [HttpGet("/")]
        public ActionResult Index(){
                return View(Vendor._allVendors);
            }
        

        [HttpGet("/Vendors/{id}")]
        public ActionResult Show(int id){
            return View(Vendor.getVendorById(id));
        }

        [HttpPost("/Vendors/new")]
        public ActionResult New(string newVendorName){
            Vendor newVendor = new Vendor(newVendorName);
        }
    }
}