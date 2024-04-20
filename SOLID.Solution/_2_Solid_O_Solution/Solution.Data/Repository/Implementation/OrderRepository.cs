using _2_Solid_O_Solution.Models;
using _2_Solid_O_Solution.Solution.Data.Repository.Interface;

namespace _2_Solid_O_Solution.Solution.Data.Repository.Implementation
{
    public class OrderRepository : IOrderRepository
    {
        public bool CreateOrder(OrderHdrDTO order)
        {
            return true;
        }
    }
}
