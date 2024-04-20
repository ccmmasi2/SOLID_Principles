using _3_Solid_L_Solution.Models;
using _3_Solid_L_Solution.Solution.Data.ObjectRepository.Interface;
using _3_Solid_L_Solution.Utils.Notification;

namespace _3_Solid_L_Solution.Solution.API.Services
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

        public IEnumerable<object> GetAll()
        {
            var list = _orderRepository.GetAll();

            return list;
        }

        public object GetOne(string filter)
        {
            var item = _orderRepository.GetOne(filter);

            return item;
        }

        public bool Update(object item)
        {
            var booleanValue = _orderRepository.Update(item);

            return booleanValue;
        }
    }
}
