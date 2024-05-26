﻿namespace E_CommerceManageMentSystem.Models
{
    public class OrderItem
    {

        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public int VariantID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Order Order { get; set; }
        public Variant Variant { get; set; }
    }
}
