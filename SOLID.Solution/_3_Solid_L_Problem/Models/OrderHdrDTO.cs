﻿namespace _3_Solid_L_Problem.Models
{
    public class OrderHdrDTO
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public string ShippingAddress { get; set; }
        public List<OrderDtlDTO> LDetails { get; set; }
    }
}