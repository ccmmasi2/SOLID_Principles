using _2_Solid_O_Solution.Models;

namespace _2_Solid_O_Solution.Solution.Data.ObjectRepository.Interface
{
    public interface IInvoiceRepository
    {
        bool CreateInvoice(OrderHdrDTO order);
    }
}
