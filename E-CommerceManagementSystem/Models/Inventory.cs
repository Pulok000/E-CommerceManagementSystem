using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_CommerceManageMentSystem.Models
{
    public class Inventory
    {
        [Key]
        public int InventoryID { get; set; }

        public int VariantID { get; set; }
        public Variant Variant { get; set; }

        public int StockLevel { get; set; }

        public int ReorderLevel { get; set; }
    }
}
