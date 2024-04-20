using _2_Solid_O_Problem.Models;

namespace _2_Solid_O_Problem.Solution.Data.ObjectRepository.Interface
{
    public interface IInvoiceRepository
    {
        bool CreateInvoice(OrderHdrDTO order);
    }
}
