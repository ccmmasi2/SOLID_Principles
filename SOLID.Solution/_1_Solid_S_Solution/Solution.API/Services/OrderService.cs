using _1_Solid_S_Solution.Models;
using _1_Solid_S_Solution.Solution.Data.Repository.Interface;
using _1_Solid_S_Solution.Utils.Interface;

namespace _1_Solid_S_Solution.Solution.API.Services
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
