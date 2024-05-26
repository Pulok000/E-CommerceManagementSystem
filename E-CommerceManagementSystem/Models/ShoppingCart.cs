using System.Collections.Generic;

namespace E_CommerceManageMentSystem.Models
{
    public class ShoppingCart
    {
        public int CartID { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
    }
}
