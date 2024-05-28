using E_CommerceManageMentSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceManageMentSystem.Data
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<ProductPromotion> ProductPromotions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Product to Variant relationship
            modelBuilder.Entity<Product>()
                .HasMany(p => p.Variants)
                .WithOne(v => v.Product)
                .HasForeignKey(v => v.ProductID);

            // Configure Variant to Inventory relationship
            modelBuilder.Entity<Variant>()
                .HasOne(v => v.Inventory)
                .WithOne(i => i.Variant)
                .HasForeignKey<Inventory>(i => i.VariantID);

            // Configure Customer to Address relationship
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Addresses)
                .WithOne(a => a.Customer)
                .HasForeignKey(a => a.CustomerID);

            // Configure Customer to Order relationship
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Orders)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.CustomerID);

            // Configure Customer to ShoppingCart relationship
            modelBuilder.Entity<Customer>()
                .HasOne(c => c.ShoppingCart)
                .WithOne(sc => sc.Customer)
                .HasForeignKey<ShoppingCart>(sc => sc.CustomerID);

            // Configure Order to OrderItem relationship
            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderItems)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderID);

            // Configure OrderItem to Variant relationship
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Variant)
                .WithMany()
                .HasForeignKey(oi => oi.VariantID);

            // Configure ShoppingCart to CartItem relationship
            modelBuilder.Entity<ShoppingCart>()
                .HasMany(sc => sc.CartItems)
                .WithOne(ci => ci.ShoppingCart)
                .HasForeignKey(ci => ci.CartID);

            // Configure CartItem to Variant relationship
            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Variant)
                .WithMany()
                .HasForeignKey(ci => ci.VariantID);

            // Configure Product to Discount relationship
            modelBuilder.Entity<Product>()
                .HasMany(p => p.Discounts)
                .WithOne(d => d.Product)
                .HasForeignKey(d => d.ProductID);

            // Configure many-to-many relationship between Product and Promotion
            modelBuilder.Entity<ProductPromotion>()
                .HasKey(pp => new { pp.ProductID, pp.PromotionID });

            modelBuilder.Entity<ProductPromotion>()
                .HasOne(pp => pp.Product)
                .WithMany(p => p.ProductPromotions)
                .HasForeignKey(pp => pp.ProductID);

            modelBuilder.Entity<ProductPromotion>()
                .HasOne(pp => pp.Promotion)
                .WithMany(p => p.ProductPromotions)
                .HasForeignKey(pp => pp.PromotionID);
        }
    }
}
