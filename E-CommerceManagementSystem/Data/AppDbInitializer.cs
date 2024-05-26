using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System;
using E_CommerceManageMentSystem.Models;
using System.Linq;
using E_CommerceManageMentSystem.Data.Enums;

namespace E_CommerceManageMentSystem.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                //Products
                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Product>()
                    {
                new Product()
                {
                    Name = "Product 1",
                   
                    Description = "This is the description of the first Product",
                    Price = 10.00m,
                    Category = Category.Toys,
                    Variants = new List<Variant>(), // Assuming you have a Variant class
                    Discounts = new List<Discount>(), // Assuming you have a Discount class
                    ProductPromotions = new List<ProductPromotion>() // Assuming you have a ProductPromotion class
                },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
