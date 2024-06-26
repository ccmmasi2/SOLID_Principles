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
    public class InvoiceController
    {
        private InvoiceService _invoiceService;

        public InvoiceController(InvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        public bool CreateInvoice(OrderHdrDTO order)
        {
            return _invoiceService.CreateInvoice(order);
        }

        public IEnumerable<object> GetAll()
        {
            var list = _invoiceService.GetAll();

            return list;
        }

        public object GetOne(string filter)
        {
            var item = _invoiceService.GetOne(filter);

            return item;
        }
    }
}
