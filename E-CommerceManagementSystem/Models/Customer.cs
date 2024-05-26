using System.Collections.Generic;
using System.Net;

namespace E_CommerceManageMentSystem.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
