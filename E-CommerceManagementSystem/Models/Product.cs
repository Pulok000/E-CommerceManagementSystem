using System.Collections.Generic;

namespace E_CommerceManageMentSystem.Models
{
    public class Product
    {

        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public ICollection<Variant> Variants { get; set; }
        public ICollection<Discount> Discounts { get; set; }

    }
}
