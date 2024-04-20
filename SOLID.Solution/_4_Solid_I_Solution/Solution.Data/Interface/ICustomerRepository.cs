using _4_Solid_I_Solution.Models;

namespace _4_Solid_I_Solution.Solution.Data.Interface
{
    public interface ICustomerRepository
    {
        void CreateCustomer(CustomerDTO customer);
    }
}
