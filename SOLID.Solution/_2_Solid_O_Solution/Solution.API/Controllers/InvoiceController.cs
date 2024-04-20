using _2_Solid_O_Solution.Models;
using _2_Solid_O_Solution.Solution.API.Services;

namespace _2_Solid_O_Solution.Solution.API.Controllers
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
