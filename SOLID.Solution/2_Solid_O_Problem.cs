using System;

namespace Solid._2_Solid_O_Problem
{
    public class OrderService
    {
        private IOrderRepository _orderRepository;
        private IInvoiceRepository _invoiceRepository;
        private INotificationService _notificationRepository;

        public OrderService(IOrderRepository orderRepository, IInvoiceRepository invoiceRepository, INotificationService notificationRepository)
        {
            _orderRepository = orderRepository;
            _invoiceRepository = invoiceRepository;
            _notificationRepository = notificationRepository;
        }

        public void SaveOrder(OrderHdrDTO order)
        {
            _orderRepository.InsertOrder(order);
            var invoice = _invoiceRepository.CreateInvoice(order);
            _notificationRepository.EmailInvoice(invoice);
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

    #region order

    interface IOrderRepository
    {
        bool CreateOrder(OrderHdrDTO order);
    }

    class OrderRepository : IOrderRepository
    {
        public bool CreateOrder(OrderHdrDTO order)
        {
            return true;
        }
    }

    #endregion

    #region invoice

    interface IInvoiceRepository
    {
        bool CreateInvoice(OrderHdrDTO order);
    }

    class InvoiceRepository : IInvoiceRepository
    {
        public bool CreateOrder(OrderHdrDTO order)
        {
            return true;
        }
    }

    #endregion

    #region notification

    interface INotificationService
    {
        bool SendEmail(InvoiceHdrDTO invoice);
    }

    class NotificationService : INotificationService
    {
        public bool SendEmail(InvoiceHdrDTO invoice)
        {
            return true;
        }
    }

    #endregion

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