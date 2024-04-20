using _1_Solid_S_Solution.Models;

namespace _1_Solid_S_Solution.Solution.Data.Repository.Interface
{
    public interface IInvoiceRepository
    {
        bool CreateInvoice(OrderHdrDTO order);
    }
}
