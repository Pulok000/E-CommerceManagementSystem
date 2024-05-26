namespace E_CommerceManageMentSystem.Models
{
    public class Inventory
    {
        public int InventoryID { get; set; }
        public int VariantID { get; set; }
        public int StockLevel { get; set; }
        public int ReorderLevel { get; set; }
        public Variant Variant { get; set; }
    }
}
