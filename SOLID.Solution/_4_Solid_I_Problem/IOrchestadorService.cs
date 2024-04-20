using _4_Solid_I_Problem.Models;

namespace _4_Solid_I_Problem
{
    public interface IOrchestadorService
    {
        void CreateCategory(CategoryDTO category);
        void CreateProduct(ProductDTO product);
        void CreateCustomer(CustomerDTO customer);
        void CreateStock(StockDTO stock);
    }
}
