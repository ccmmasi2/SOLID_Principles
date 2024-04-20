using _2_Solid_O_Problem.Models;
using _2_Solid_O_Problem.Solution.Data.ObjectRepository.Interface;

namespace _2_Solid_O_Problem.Solution.Data.ObjectRepository.Implementation
{
    public class InvoiceRepository : IInvoiceRepository
    {
        public bool CreateInvoice(OrderHdrDTO order)
        {
            return true;
        }
    }
}
