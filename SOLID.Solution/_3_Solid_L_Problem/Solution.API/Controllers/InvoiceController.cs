using _3_Solid_L_Problem.Models;
using _3_Solid_L_Problem.Solution.API.Services;

namespace _3_Solid_L_Problem.Solution.API.Controllers
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
