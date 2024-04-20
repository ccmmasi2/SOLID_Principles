using _3_Solid_L_Problem.Models;
using _3_Solid_L_Problem.Solution.Data.ObjectRepository.Interface;

namespace _3_Solid_L_Problem.Solution.Data.ObjectRepository.Implementation
{
    public class InvoiceRepository : IInvoiceRepository
    {
        public bool CreateInvoice(OrderHdrDTO order)
        {
            return true;
        }
    }
}
