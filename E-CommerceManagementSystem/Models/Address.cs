namespace E_CommerceManageMentSystem.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        public int CustomerID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public Customer Customer { get; set; }
    }
}
