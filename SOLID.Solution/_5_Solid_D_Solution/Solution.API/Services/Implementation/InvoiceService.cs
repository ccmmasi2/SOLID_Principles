using _5_Solid_D_Solution.Models;
using _5_Solid_D_Solution.Solution.API.Services.Interface;

namespace _5_Solid_D_Solution.Solution.API.Services.Implementation
{
    public class InvoiceService : IInvoiceService
    {
        public bool CreateInvoice(OrderHdrDTO order)
        {
            return true;
        }

        public IEnumerable<object> GetAll()
        {
            return null;
        }

        public object GetOne(string filter)
        {
            return null;
        }
    }
}
