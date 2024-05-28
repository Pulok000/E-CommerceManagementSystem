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
                if (false)
                {
                    context.Products.AddRange(new List<Product>()
                    {
                        new Product()
                        {
                            Name = "H.MATISSE",
                            Description = "Its a painting",
                            Price = 3000,
                            Category = Category.Paintings,

                            ProductPictureURL="img/product/H_Matisse.jpg",
                            Variants = new List<Variant>(),
                            Discounts = new List<Discount>(),
                            ProductPromotions = new List<ProductPromotion>()
                        },
                                                new Product()
                        {
                            Name = "Product 2 Meat",
                            Description = "This is the description of the first Product",
                            Price = 525,
                            Category = Category.HomeGoods,
                            ProductPictureURL="img/product/product-1.jpg",
                            Variants = new List<Variant>(),
                            Discounts = new List<Discount>(),
                            ProductPromotions = new List<ProductPromotion>()
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
