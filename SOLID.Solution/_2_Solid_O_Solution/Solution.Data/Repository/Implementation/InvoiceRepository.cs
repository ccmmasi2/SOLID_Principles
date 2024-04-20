using _2_Solid_O_Solution.Models;
using _2_Solid_O_Solution.Solution.Data.Repository.Interface;

namespace _2_Solid_O_Solution.Solution.Data.Repository.Implementation
{
    public class InvoiceRepository : IInvoiceRepository
    {
        public bool CreateInvoice(OrderHdrDTO order)
        {
            return true;
        }
    }
}
