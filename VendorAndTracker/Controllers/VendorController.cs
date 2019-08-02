using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VendorAndTracker.Models;
namespace VendorAndTracker.Controllers{

    class VendorController : Controller{

        [HttpGet("/Vendor")]
        public ActionResult Index(){
                return View(Vendor._allVendors);
            }
        

        [HttpGet("/Vendor/{vendorId}")]
        public ActionResult Show(int vendorId){
            return View(Vendor.getVendorById(vendorId));
        }

        [HttpPost("/Vendor")]
        public ActionResult Create(string newVendorName){
            Vendor newVendor = new Vendor(newVendorName); //automatically adds to vendorlist
            return RedirectToAction("Index");

        }

        [HttpGet("/Vendor/new")]
        public ActionResult New(){
            return View();
        }
    }
}