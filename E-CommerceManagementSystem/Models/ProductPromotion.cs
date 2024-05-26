namespace E_CommerceManageMentSystem.Models
{
    public class ProductPromotion
    {
        public int ProductID { get; set; }
        public Product Product { get; set; }

        public int PromotionID { get; set; }
        public Promotion Promotion { get; set; }
    }
}
