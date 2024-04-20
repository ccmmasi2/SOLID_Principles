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

        public IEnumerable<object> GetAll()
        {
            throw new NotImplementedException();
        }

        public object GetOne(string filter)
        {
            throw new NotImplementedException();
        }

        public bool Insert(object item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(object item)
        {
            throw new NotImplementedException();
        }

        public bool Update(object item)
        {
            throw new NotImplementedException();
        }
    }
}
