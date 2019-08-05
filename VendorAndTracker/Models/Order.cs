using System;
using System.Collections.Generic;

namespace VendorAndTracker.Models{
    public class Order
    {
        public int _id {get; set;}

        public string _name {get; set;}
        public Order(string name){
            _name = name;
        }
    }
}