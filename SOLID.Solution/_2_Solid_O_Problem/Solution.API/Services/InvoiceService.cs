using _2_Solid_O_Problem.Models;
using _2_Solid_O_Problem.Solution.Data.Repository.Interface;
using _2_Solid_O_Problem.Utils.Interface;

namespace _2_Solid_O_Problem.Solution.API.Services
{
    /// The problem in this project is that NotificationService.SendNotification is a method that has a switch to iterate between different kind of notifications, for now has the possibility to send emails to Gmail and Hotmail, but if we need another notifications such as Personal notification, or using a broker, API, WCF or another kinds of notifications, we need to add other lines to add to the switch structure. 
    /// Here we could break Open-Close Principle, it says if we need to add another feature - functionality to a class, we should'n modify the class, instead of this, we should add an interface with the new features and implementate this interface
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
            _notificationRepository.SendNotification("messageText", TypeNotificationEnums.HotmailEmail);

            return true;
        }
    }
}
