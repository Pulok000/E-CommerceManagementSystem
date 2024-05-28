using E_CommerceManageMentSystem.Data.Enums;
using E_CommerceManageMentSystem.Models;
using System.Collections.Generic;

namespace E_CommerceManageMentSystem.Data.ViewModels
{
    public class ProductsViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public int PageNumber { get; set; }
        public int TotalPages { get; set; }
    }
}
