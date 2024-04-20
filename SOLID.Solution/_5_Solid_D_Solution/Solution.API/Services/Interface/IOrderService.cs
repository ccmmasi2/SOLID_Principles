using _5_Solid_D_Solution.Models;

namespace _5_Solid_D_Solution.Solution.API.Services.Interface
{
    public interface IOrderService
    {
        bool CreateOrder(OrderHdrDTO order);

        IEnumerable<object> GetAll();

        object GetOne(string filter);

        bool Update(object item);
    }
}
