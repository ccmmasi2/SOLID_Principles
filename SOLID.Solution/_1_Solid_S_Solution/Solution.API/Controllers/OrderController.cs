using _1_Solid_S_Solution.Models;
using _1_Solid_S_Solution.Solution.API.Services;

namespace _1_Solid_S_Solution.Solution.API.Controllers
{
    public class OrderController
    {
        private OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        public bool CreateOrder(OrderHdrDTO order)
        {
            return _orderService.CreateOrder(order);
        }
    }
}
