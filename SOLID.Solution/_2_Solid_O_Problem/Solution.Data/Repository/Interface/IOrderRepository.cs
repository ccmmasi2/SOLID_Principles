using _2_Solid_O_Problem.Models;

namespace _2_Solid_O_Problem.Solution.Data.Repository.Interface
{
    public interface IOrderRepository
    {
        bool CreateOrder(OrderHdrDTO order);
    }
}
