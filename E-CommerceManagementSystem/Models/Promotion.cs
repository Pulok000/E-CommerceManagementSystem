using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_CommerceManageMentSystem.Models
{
    public class Promotion
    {
        [Key]
        public int PromotionID { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public decimal DiscountAmount { get; set; }

        [Required]
        public DateTime ExpirationDate { get; set; }

        public ICollection<ProductPromotion> ProductPromotions { get; set; }
    }
}
