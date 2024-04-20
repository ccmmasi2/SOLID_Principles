using _5_Solid_D_Solution.Models;
using _5_Solid_D_Solution.Solution.API.Services.Interface;

namespace _5_Solid_D_Solution.Solution.API.Controllers
{
    public class OrderController
    {
        private IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public bool CreateOrder(OrderHdrDTO order)
        {
            return _orderService.CreateOrder(order);
        }

        public IEnumerable<object> GetAll()
        {
            var list = _orderService.GetAll();

            return list;
        }

        public object GetOne(string filter)
        {
            var item = _orderService.GetOne(filter);

            return item;
        }

        public object Update(object item)
        {
            var booleanValue = _orderService.Update(item);

            return booleanValue;
        }
    }
}
