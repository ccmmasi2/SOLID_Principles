using _3_Solid_L_Problem.Models;

namespace _3_Solid_L_Problem.Solution.Data.ObjectRepository.Interface
{
    public interface IInvoiceRepository
    {
        bool CreateInvoice(OrderHdrDTO order);
    }
}
