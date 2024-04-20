﻿using _1_Solid_S_Problem.Models;

namespace _1_Solid_S_Problem
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
            this.CreateOrder(order);
            var invoice = this.CreateInvoice(order);
            this.EmailInvoice("invoice");
        }

        public bool CreateOrder(OrderHdrDTO order)
        {
            return true;
        }

        public bool CreateInvoice(OrderHdrDTO order)
        {
            return true;
        }

        public bool EmailInvoice(string message)
        {
            return true;
        }
    }
}
