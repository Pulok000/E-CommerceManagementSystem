namespace E_CommerceManageMentSystem.Models
{
    public class Variant
    {
        public int VariantID { get; set; }
        public int ProductID { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public Product Product { get; set; }
        public Inventory Inventory { get; set; }
    }
}
