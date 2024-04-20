using System;

namespace Solid._1_Solid_S_Solution
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
            _notificationRepository.SendEmail(order);
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

    public class InvoiceService
    {
        private IOrderRepository _orderRepository;
        private IInvoiceRepository _invoiceRepository;
        private INotificationService _notificationRepository;

        public InvoiceService(IOrderRepository orderRepository, IInvoiceRepository invoiceRepository, INotificationService notificationRepository)
        {
            _orderRepository = orderRepository;
            _invoiceRepository = invoiceRepository;
            _notificationRepository = notificationRepository;
        }

        public void SaveOrder(OrderHdrDTO order)
        {
            _orderRepository.InsertOrder(order);
            var invoice = _invoiceRepository.CreateInvoice(order);
            _notificationRepository.SendEmail(invoice);
        }

        public bool InsertOrder(OrderHdrDTO order)
        {
            _invoiceRepository.CreateInvoice(order);
            _notificationRepository.SendEmail(invoice
            return true;
        }

        public InvoiceHdrDTO CreateInvoice(OrderHdrDTO order)
        {
            return new Invoice();
        }

        public bool SendEmail(Invoice invoice)
        {
            return true;
        }
    } 
}