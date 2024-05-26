namespace E_CommerceManageMentSystem.Models
{
    public class CartItem
    {
        public int CartItemID { get; set; }
        public int CartID { get; set; }
        public int VariantID { get; set; }
        public int Quantity { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public Variant Variant { get; set; }
    }
}
