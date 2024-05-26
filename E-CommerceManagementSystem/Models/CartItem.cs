using System.ComponentModel.DataAnnotations;

namespace E_CommerceManageMentSystem.Models
{
    public class CartItem
    {
        [Key]
        public int CartItemID { get; set; }

        public int CartID { get; set; }
        public ShoppingCart ShoppingCart { get; set; }

        public int VariantID { get; set; }
        public Variant Variant { get; set; }

        public int Quantity { get; set; }
    }
}
