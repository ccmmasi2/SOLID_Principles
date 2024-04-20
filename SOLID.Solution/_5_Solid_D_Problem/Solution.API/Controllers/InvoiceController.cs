using _5_Solid_D_Problem.Models;
using _5_Solid_D_Problem.Solution.API.Services;

namespace _5_Solid_D_Problem.Solution.API.Controllers
{
    public class InvoiceController
    {
        private InvoiceService _invoiceService;

        public InvoiceController(InvoiceService invoiceService)
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
