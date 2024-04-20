using _1_Solid_S_Solution.Models;
using _1_Solid_S_Solution.Solution.Data.ObjectRepository.Interface;
using _1_Solid_S_Solution.Utils.Interface;

namespace _1_Solid_S_Solution.Solution.API.Services
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
