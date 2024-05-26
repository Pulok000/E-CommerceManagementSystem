using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_CommerceManageMentSystem.Models
{
    public class ShoppingCart
    {
        [Key]
        public int CartID { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
    }
}
