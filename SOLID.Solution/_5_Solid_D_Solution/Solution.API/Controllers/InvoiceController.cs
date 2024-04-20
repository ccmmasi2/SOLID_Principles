using _5_Solid_D_Solution.Models;
using _5_Solid_D_Solution.Solution.API.Services.Interface;

namespace _5_Solid_D_Solution.Solution.API.Controllers
{
    public class InvoiceController
    {
        private IInvoiceService _invoiceService;

        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        public bool CreateInvoice(OrderHdrDTO order)
        {
            return _invoiceService.CreateInvoice(order);
        }

        public IEnumerable<object> GetAll()
        {
            var list = _invoiceService.GetAll();

            return list;
        }

        public object GetOne(string filter)
        {
            var item = _invoiceService.GetOne(filter);

            return item;
        }
    }
}
