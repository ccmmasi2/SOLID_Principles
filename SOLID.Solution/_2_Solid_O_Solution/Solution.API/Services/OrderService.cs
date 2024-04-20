using _2_Solid_O_Solution.Models;
using _2_Solid_O_Solution.Solution.Data.Repository.Interface;
using _2_Solid_O_Solution.Utils.Notification;

namespace _2_Solid_O_Solution.Solution.API.Services
{
    public class OrderService
    {
        private IOrderRepository _orderRepository;
        private INotificationService _notificationRepository;

        public OrderService(IOrderRepository orderRepository, INotificationService notificationRepository)
        {
            _orderRepository = orderRepository;
            _notificationRepository = notificationRepository;
        }

        public bool CreateOrder(OrderHdrDTO order)
        {
            _orderRepository.CreateOrder(order);
            _notificationRepository.SendNotification("messageText");

            return true;
        }
    }
}
