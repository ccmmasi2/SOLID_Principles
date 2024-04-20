using _3_Solid_L_Solution.Models;
using _3_Solid_L_Solution.Solution.Data.ObjectRepository.Interface;

namespace _3_Solid_L_Solution.Solution.Data.ObjectRepository.Implementation
{
    public class InvoiceRepository : IInvoiceRepository
    {
        public bool CreateInvoice(OrderHdrDTO order)
        {
            return true;
        }

        public IEnumerable<object> GetAll()
        {
            throw new NotImplementedException();
        }

        public object GetOne(string filter)
        {
            throw new NotImplementedException();
        }
    }
}
