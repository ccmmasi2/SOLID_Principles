using _1_Solid_S_Solution.Models;
using _1_Solid_S_Solution.Solution.Data.ObjectRepository.Interface;

namespace _1_Solid_S_Solution.Solution.Data.ObjectRepository.Implementation
{
    public class InvoiceRepository : IInvoiceRepository
    {
        public bool CreateInvoice(OrderHdrDTO order)
        {
            return true;
        }
    }
}
