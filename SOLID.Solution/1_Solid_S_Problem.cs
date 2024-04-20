﻿using System;

namespace Solid._1_Solid_S_Problem
{
    public class OrderService
    {
        /// <summary>
        /// This class has different methods, and the SaveOrder method calls others
        /// Exist a high coupling. 
        /// This method is broken some principles and good practices: 
        ///     1 - The first Solid principle: Single Responsibility, This class should have an unique responsibility, but instead of this, has different responsibilities, is allowed to create orders, invoices and send email. 
        ///     2 - High cohesion and low coupling: Exist a quite high coupling in this class
        ///     3 - There aren't any abstraction here, and is broken one of the principles of OOP: abstraction, the code should reference to abstractions instead of concret classes
        ///     4 - Another thing we can implement here is encapsulation, one of the OOP principles, that says you should show the information you need to show and restrict access or visualization to methods or code that you need to maintein hidden. 
        /// </summary>
        /// <param name="order"></param>
        public void SaveOrder(OrderHdrDTO order)
        {
            this.InsertOrder(order);
            var invoice = this.CreateInvoice(order);
            this.EmailInvoice(invoice);
        }

        public bool InsertOrder(OrderHdrDTO order)
        {
            return true;
        }

        public InvoiceHdrDTO CreateInvoice(OrderHdrDTO order)
        {
            return new Invoice();
        }

        public bool EmailInvoice(Invoice invoice)
        {
            return true;
        }
    }

    #region DTOs

    public class OrderHdrDTO
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public string ShippingAddress { get; set; }
        public List<OrderDtlDTO> LDetails { get; set; }
    }

    public class OrderDtlDTO
    {
        public int ID { get; set; }
        public int Qty { get; set; }
        public long Price { get; set; }
        public int OrderHdrId { get; set; }
        public int ProductId { get; set; }
    }

    public class InvoiceHdrDTO
    {
        public int ID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int CustomerId { get; set; }
        public int OrderHdrId { get; set; }
    }

    #endregion 
}