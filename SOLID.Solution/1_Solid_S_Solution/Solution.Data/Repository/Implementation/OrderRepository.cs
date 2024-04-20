using _1_Solid_S_Solution.Models;
using _1_Solid_S_Solution.Solution.Data.Repository.Interface;

namespace _1_Solid_S_Solution.Solution.Data.Repository.Implementation
{
    public class OrderRepository : IOrderRepository
    {
        public bool CreateOrder(OrderHdrDTO order)
        {
            return true;
        }
    }
}
