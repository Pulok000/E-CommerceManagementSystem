﻿using System.ComponentModel.DataAnnotations;

namespace E_CommerceManageMentSystem.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemID { get; set; }

        public int OrderID { get; set; }
        public Order Order { get; set; }

        public int VariantID { get; set; }
        public Variant Variant { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

    }
}
