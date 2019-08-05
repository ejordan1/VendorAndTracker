using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VendorAndTracker.Models;
namespace VendorAndTracker{
    public class OrderController : Controller 
    {

         [HttpGet("/Order")]
        public ActionResult Index(){
            Console.WriteLine("Order CONTROLLER");
            return RedirectToAction("2");
        }

        [HttpGet("/vendor/{vendorId}/{orderId}")]
        public ActionResult Show(int vendorId, int orderId){
            Dictionary<string, object> vendorAndItem = new Dictionary<string, object>();
            Vendor thisVendor = Vendor.getVendorById(vendorId);
            vendorAndItem["vendor"] = thisVendor;
            vendorAndItem["order"] = thisVendor.getOrderById(orderId);
            return View(vendorAndItem);
        }

    


        [HttpGet("/vendor/{vendorId}/new")]
        public ActionResult New(int vendorId){
            return View(Vendor.getVendorById(vendorId));
        }
    }
}

//this is done differently than the example: the example has it where it 
//creates a new item but as a category controller