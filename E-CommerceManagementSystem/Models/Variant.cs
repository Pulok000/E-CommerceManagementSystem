using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_CommerceManageMentSystem.Models
{
    public class Variant
    {
        [Key]
        public int VariantID { get; set; }

        public int ProductID { get; set; }
        public Product Product { get; set; }

        public string Color { get; set; }

        public string Size { get; set; }

        public Inventory Inventory { get; set; }
    }
}
