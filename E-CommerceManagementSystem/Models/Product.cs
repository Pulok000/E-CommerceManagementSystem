using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using E_CommerceManageMentSystem.Data.Enums;

namespace E_CommerceManageMentSystem.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public Category Category { get; set; }

        public string ProductPictureURL { get; set; }

        public ICollection<Variant> Variants { get; set; }
        public ICollection<Discount> Discounts { get; set; }
        public ICollection<ProductPromotion> ProductPromotions { get; set; }

    }
}
