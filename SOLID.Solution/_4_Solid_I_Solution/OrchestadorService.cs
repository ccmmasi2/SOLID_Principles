using _4_Solid_I_Solution.Models;
using _4_Solid_I_Solution.Solution.Data.Interface;

namespace _4_Solid_I_Problem
{
    public class OrchestadorService : ICategoryRepository, IProductRepository, ICustomerRepository, IStockRepository
    {
        public void CreateCategory(CategoryDTO category)
        {
            throw new NotImplementedException();
        }

        public void CreateCustomer(CustomerDTO customer)
        {
            throw new NotImplementedException();
        }

        public void CreateProduct(ProductDTO product)
        {
            throw new NotImplementedException();
        }

        public void CreateStock(StockDTO stock)
        {
            throw new NotImplementedException();
        }
    }
}
