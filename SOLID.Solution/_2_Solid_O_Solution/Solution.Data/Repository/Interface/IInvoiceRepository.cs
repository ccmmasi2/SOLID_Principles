using _2_Solid_O_Solution.Models;

namespace _2_Solid_O_Solution.Solution.Data.Repository.Interface
{
    public interface IInvoiceRepository
    {
        bool CreateInvoice(OrderHdrDTO order);
    }
}
