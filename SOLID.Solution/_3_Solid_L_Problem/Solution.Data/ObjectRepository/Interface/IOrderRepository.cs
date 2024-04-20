using _3_Solid_L_Problem.Models;
using _3_Solid_L_Problem.Solution.Data.BaseRepository;

namespace _3_Solid_L_Problem.Solution.Data.ObjectRepository.Interface
{
    public interface IOrderRepository : IRepository
    {
        bool CreateOrder(OrderHdrDTO order);
    }
}
