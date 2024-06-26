﻿using _3_Solid_L_Solution.Models;
using _3_Solid_L_Solution.Solution.API.Services;

namespace _3_Solid_L_Solution.Solution.API.Controllers
{
    /*
     SOLID
Liskov substitution principle. (Liskov was who created this principle)
This principle says: 
	The derived clases could be replaceables by their base clases without altering the operation of the system

In this project we have the following problems:
Please note the BaseRepository folder and IRepository, Repository files
The Base repository has the methods: GetAll, GetOne Insert, Update and Remove
And note that ObjectRepository clases have to implementate all of those methods, regardless of whether the class need all of them or only one. 
For this excercise suppose for an Order we are allowed to CreateOrder, GetAll, GetOne, Update , but for Invoice we can't Update it. 
on ObjectRepository -> InvoiceRepository we are implementing all of methods, although we already know we don't need all of them. 

We are breaking the Liskov substitution principle, because we can't replace our derived class InvoiceRepository by its parent BaseRepository. For one class We only need Create, GetAll and GetOne but Update, and as we are using this interface, we have to implement all of these methods, even we don't needed.  
     */
    public class OrderController
    {
        private OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        public bool CreateOrder(OrderHdrDTO order)
        {
            return _orderService.CreateOrder(order);
        }

        public IEnumerable<object> GetAll()
        {
            var list = _orderService.GetAll();

            return list;
        }

        public object GetOne(string filter)
        {
            var item = _orderService.GetOne(filter);

            return item;
        }

        public object Update(object item)
        {
            var booleanValue = _orderService.Update(item);

            return booleanValue;
        }
    }
}
