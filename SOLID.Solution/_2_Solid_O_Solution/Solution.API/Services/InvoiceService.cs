using _2_Solid_O_Solution.Models;
using _2_Solid_O_Solution.Solution.Data.Repository.Interface;
using _2_Solid_O_Solution.Utils.Notification;

namespace _2_Solid_O_Solution.Solution.API.Services
{
    public class InvoiceService
    {
        private IInvoiceRepository _invoiceRepository;
        private INotificationService _notificationRepository;

        public InvoiceService(IInvoiceRepository invoiceRepository, INotificationService notificationRepository)
        {
            _invoiceRepository = invoiceRepository;
            _notificationRepository = notificationRepository;
        }

        public bool CreateInvoice(OrderHdrDTO order)
        {
            _invoiceRepository.CreateInvoice(order);
            _notificationRepository.SendNotification("messageText");

            return true;
        }
    }
}
