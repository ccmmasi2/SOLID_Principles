using _2_Solid_O_Problem.Models;
using _2_Solid_O_Problem.Solution.Data.Repository.Interface;

namespace _2_Solid_O_Problem.Solution.Data.Repository.Implementation
{
    public class OrderRepository : IOrderRepository
    {
        public bool CreateOrder(OrderHdrDTO order)
        {
            return true;
        }
    }
}
