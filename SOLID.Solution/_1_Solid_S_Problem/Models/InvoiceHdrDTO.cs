namespace _1_Solid_S_Problem.Models
{
    public class InvoiceHdrDTO
    {
        public int ID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int CustomerId { get; set; }
        public int OrderHdrId { get; set; }
    }
}
