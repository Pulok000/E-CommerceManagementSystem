using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace E_CommerceManageMentSystem.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        public ICollection<Address> Addresses { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
