using _3_Solid_L_Problem.Models;
using _3_Solid_L_Problem.Solution.Data.ObjectRepository.Interface;
using _3_Solid_L_Problem.Utils.Notification;

namespace _3_Solid_L_Problem.Solution.API.Services
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
