using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VendorAndTracker.Models;
namespace VendorAndTracker{
    public class OrderController : Controller {

        [HttpGet("/vendor/{vendorId}/{orderId}")]
        public ActionResult Show(int vendorId, int orderId){
            Dictionary<string, object> vendorAndItem = new Dictionary<string, object>();
            Vendor thisVendor = Vendor.getVendorById(vendorId);
            vendorAndItem["vendor"] = thisVendor;
            vendorAndItem["item"] = thisVendor.getOrderById(orderId);
            return View(vendorAndItem);
        }

        [HttpPost("/vendor/{vendorId}/new")]
        public ActionResult Create(int vendorId, string orderName){
            Order newOrder = new Order(orderName);
            Vendor.getVendorById(vendorId).addOrder(newOrder);
            return RedirectToAction("/vendor/{vendorId}");
        }


        [HttpGet("/vendor/{vendorId}/new")]
        public ActionResult New(int vendorId){
            return View(Vendor.getVendorById(vendorId));
        }
    }
}

//this is done differently than the example: the example has it where it 
//creates a new item but as a category controller