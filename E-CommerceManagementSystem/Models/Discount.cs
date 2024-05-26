using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_CommerceManageMentSystem.Models
{
    public class Discount
    {
        [Key]
        public int DiscountID { get; set; }

        [Required]
        public int ProductID { get; set; }

        public Product Product { get; set; }

        [Required]
        public decimal DiscountPercentage { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }
    }
}
