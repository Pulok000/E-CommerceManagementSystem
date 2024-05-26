using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_CommerceManageMentSystem.Models
{
    public class Promotion
    {
        [Key]
        public int PromotionID { get; set; }
        public string Code { get; set; }
        public decimal? DiscountAmount { get; set; }
        public DateTime ExpirationDate { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
