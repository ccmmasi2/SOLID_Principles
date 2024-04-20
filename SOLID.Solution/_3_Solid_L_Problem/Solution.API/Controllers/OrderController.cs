using _3_Solid_L_Problem.Models;
using _3_Solid_L_Problem.Solution.API.Services;

namespace _3_Solid_L_Problem.Solution.API.Controllers
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
