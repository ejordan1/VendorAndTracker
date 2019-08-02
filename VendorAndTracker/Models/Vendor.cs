using System;
using System.Collections.Generic;

namespace VendorAndTracker.Models{
    public class Vendor{
        public string _name {get; set;}

        public int _id {get; set;}
        private static int _idCounter = 0;
        public static List<Vendor> _allVendors;

        public Vendor(string name){
            _name = name;
            _idCounter++;
            _id = _idCounter;
            if (_allVendors == null){
                _allVendors = new List<Vendor>();
            }
            _allVendors.Add(this);

        }

        public static Vendor getVendorById(int id){
            for(int i = 0; i < _allVendors.Count; i++){
                if (_allVendors[i]._id == id){
                    return _allVendors[i];
                }
            }
            throw new System.ArgumentException("No vendor of this Id");
        }
    }
}