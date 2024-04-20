using _3_Solid_L_Problem.Models;
using _3_Solid_L_Problem.Solution.Data.ObjectRepository.Implementation;
using _3_Solid_L_Problem.Solution.Data.ObjectRepository.Interface;
using _3_Solid_L_Problem.Utils.Notification;

namespace _3_Solid_L_Problem.Solution.API.Services
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

        public IEnumerable<object> GetAll()
        {
            var list = _invoiceRepository.GetAll();

            return list;
        }

        public object GetOne(string filter)
        {
            var item = _invoiceRepository.GetOne(filter);

            return item;
        }
    }
}
