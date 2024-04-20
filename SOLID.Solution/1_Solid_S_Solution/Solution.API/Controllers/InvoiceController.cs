using _1_Solid_S_Solution.Models;
using _1_Solid_S_Solution.Solution.API.Services;

namespace _1_Solid_S_Solution.Solution.API.Controllers
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
    }
}
