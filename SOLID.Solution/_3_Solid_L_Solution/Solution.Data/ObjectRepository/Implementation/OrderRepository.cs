using _3_Solid_L_Solution.Models;
using _3_Solid_L_Solution.Solution.Data.ObjectRepository.Interface;

namespace _3_Solid_L_Solution.Solution.Data.ObjectRepository.Implementation
{
    public class OrderRepository : IOrderRepository
    {
        public bool CreateOrder(OrderHdrDTO order)
        {
            return true;
        }

        public IEnumerable<object> GetAll()
        {
            throw new NotImplementedException();
        }

        public object GetOne(string filter)
        {
            throw new NotImplementedException();
        }

        public bool Update(object item)
        {
            throw new NotImplementedException();
        }
    }
}
