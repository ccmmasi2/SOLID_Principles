using _3_Solid_L_Problem.Models;
using _3_Solid_L_Problem.Solution.Data.ObjectRepository.Interface;

namespace _3_Solid_L_Problem.Solution.Data.ObjectRepository.Implementation
{
    public class OrderRepository : IOrderRepository
    {
        public bool CreateOrder(OrderHdrDTO order)
        {
            return true;
        }
    }
}
