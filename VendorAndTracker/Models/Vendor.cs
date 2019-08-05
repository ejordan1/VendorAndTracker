using System;
using System.Collections.Generic;

namespace VendorAndTracker.Models{
    public class Vendor{
        public string _name {get; set;}

        public int _id {get; set;}
        private static int _idCounter = 0;
        public static List<Vendor> _allVendors = new List<Vendor>();

        public List<Order> _orders = new List<Order>();

        public Vendor(string name){
            Console.WriteLine(name + ", was passed in as name");
            this._name = name;
            Console.WriteLine(_name);
            _idCounter++;
            _id = _idCounter;
            if (_allVendors == null){
                _allVendors = new List<Vendor>();
            }
            _allVendors.Add(this);
            Console.WriteLine(_allVendors.Count);
            for(int i = 0; i < _allVendors.Count; i++){
                Console.WriteLine(_allVendors[i]._id);
            }

        }

        public void addOrder(Order orderToAdd){
            _idCounter++;
            orderToAdd._id = _idCounter;
            _orders.Add(orderToAdd);
        }

        public List<string> getOrderNames(){
            List<string> orderNames = new List<string>();
            foreach(Order order in _orders){
                orderNames.Add(order._name);
            }
            return orderNames;
        }

        public Order getOrderById(int id){
            
            for (int i = 0; i < _orders.Count; i++){
                if (_orders[i]._id == id){
                    return _orders[i];
                }
            }
            throw new System.ArgumentException("No order of this Id");
        }

        public static Vendor getVendorById(int id){
            Console.WriteLine("Getting vendor by ID: " + id);
            for(int i = 0; i < _allVendors.Count; i++){
                if (_allVendors[i]._id == id){
                    return _allVendors[i];
                }
            }
            throw new System.ArgumentException("No vendor of this Id");
        }
    }
}