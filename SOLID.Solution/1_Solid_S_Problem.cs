using System;

namespace Solid._1_Solid_S_Problem
{
    public class OrderService
    {
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