using System.ComponentModel.DataAnnotations;

namespace E_CommerceManageMentSystem.Models
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        [Required]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string ZipCode { get; set; }

        [Required]
        public string Country { get; set; }
    }
}
