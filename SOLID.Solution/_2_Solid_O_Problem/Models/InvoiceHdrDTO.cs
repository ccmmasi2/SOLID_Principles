namespace _2_Solid_O_Problem.Models
{
    public class InvoiceHdrDTO
    {
        public int ID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int CustomerId { get; set; }
        public int OrderHdrId { get; set; }
    }
}
