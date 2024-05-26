using System.Collections.Generic;

namespace E_CommerceManageMentSystem.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
