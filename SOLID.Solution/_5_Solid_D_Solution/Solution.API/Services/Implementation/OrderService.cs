using _5_Solid_D_Solution.Models;
using _5_Solid_D_Solution.Solution.API.Services.Interface;

namespace _5_Solid_D_Solution.Solution.API.Services.Implementation
{
    public class OrderService : IOrderService
    {
        public bool CreateOrder(OrderHdrDTO order)
        {
            return true;
        }

        public IEnumerable<object> GetAll()
        {
            return null;
        }

        public object GetOne(string filter)
        {
            return null;
        }

        public bool Update(object item)
        {
            return true;
        }
    }
}
