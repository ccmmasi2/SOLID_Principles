using _2_Solid_O_Solution.Models;
using _2_Solid_O_Solution.Solution.API.Services;

namespace _2_Solid_O_Solution.Solution.API.Controllers
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
