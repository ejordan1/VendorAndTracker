using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VendorAndTracker.Models;
namespace VendorAndTracker{
    public class VendorController : Controller 
    {

        [HttpGet("/Vendor")]
        public ActionResult Index(){
            return View(Vendor._allVendors);
        }


        [HttpGet("/vendor/{vendorId}")]
        public ActionResult Show(int vendorId){
            Dictionary<string, Object> vendorDict = new Dictionary<string, Object>();
            vendorDict["id"] = vendorId;
            vendorDict["vendorName"] = Vendor.getVendorById(vendorId)._name;
            vendorDict["orders"] = Vendor.getVendorById(vendorId)._orders;
            return View(vendorDict);
        }

            [HttpPost("/vendor/{vendorId}/new")]
        public ActionResult Create(int vendorId, string orderName){
            Order newOrder = new Order(orderName);
            Console.WriteLine("CREATE CONTROLLER VENDOR ID RECEIVED: " + vendorId);
            Vendor.getVendorById(vendorId).addOrder(newOrder);
            return RedirectToAction("");
        }

        [HttpPost("/vendor")]
        public ActionResult Create(string newVendorName){
            Vendor newVendor = new Vendor(newVendorName); //automatically adds to vendorlist
            return RedirectToAction("Index");

        }

        [HttpGet("/vendor/new")]
        public ActionResult New(){
            Console.WriteLine("Vendor/new, returning view");
            return View();
        }
        
        
    }
}

//this is done differently than the example: the example has it where it 
//creates a new item but as a category controller

// using System;
// using System.Collections.Generic;
// using Microsoft.AspNetCore.Mvc;
// using VendorAndTracker.Models;
// namespace VendorAndTracker.Controllers
// {

//     class VendorController : Controller
//     {

//         [HttpGet("/Vendor")]
//         public ActionResult Index(){
//             Console.WriteLine("VENDOR CONTROLLER");
//             return View();
//         }
        

//         [HttpGet("/vendor/{vendorId}")]
//         public ActionResult Show(int vendorId){
//             Dictionary<string, Object> vendorDict = new Dictionary<string, Object>();
//             vendorDict["vendorName"] = Vendor.getVendorById(vendorId)._name;
//             vendorDict["orders"] = Vendor.getVendorById(vendorId)._orders;
//             return View(Vendor.getVendorById(vendorId));
//         }

//         [HttpPost("/vendor")]
//         public ActionResult Create(string newVendorName){
//             Vendor newVendor = new Vendor(newVendorName); //automatically adds to vendorlist
//             return RedirectToAction("Index");

//         }

//         // [HttpGet("/vendor/new")]
//         // public ActionResult New(){
//         //     Console.WriteLine("Vendor/new, returning view");
//         //     return View();
//         // }
//     }
// }