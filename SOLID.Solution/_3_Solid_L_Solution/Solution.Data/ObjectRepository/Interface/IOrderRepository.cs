using _3_Solid_L_Solution.Models;
using _3_Solid_L_Solution.Solution.Data.BaseRepository;

namespace _3_Solid_L_Solution.Solution.Data.ObjectRepository.Interface
{
    public interface IOrderRepository : IGetAllRepository, IGetOneRepository, IUpdateRepository
    {
        bool CreateOrder(OrderHdrDTO order);
    }
}
