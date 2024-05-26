namespace E_CommerceManageMentSystem.Models
{
    public class ProductDiscount
    {
        public int ProductID { get; set; }
        public Product Product { get; set; }

        public int DiscountID { get; set; }
        public Discount Discount { get; set; }
    }
}
