namespace _2_Solid_O_Problem.Models
{
    public class OrderDtlDTO
    {
        public int ID { get; set; }
        public int Qty { get; set; }
        public long Price { get; set; }
        public int OrderHdrId { get; set; }
        public int ProductId { get; set; }
    }
}
