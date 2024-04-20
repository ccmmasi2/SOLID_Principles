using _2_Solid_O_Solution.Models;
using _2_Solid_O_Solution.Solution.Data.ObjectRepository.Interface;

namespace _2_Solid_O_Solution.Solution.Data.ObjectRepository.Implementation
{
    public class OrderRepository : IOrderRepository
    {
        public bool CreateOrder(OrderHdrDTO order)
        {
            return true;
        }
    }
}
