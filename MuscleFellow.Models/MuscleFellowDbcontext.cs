using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuscleFellow.Models
{
    public class MuscleFellowDbContext : IdentityDbContext<IdentityUser>
    {
        public MuscleFellowDbContext() { }
        public MuscleFellowDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShipAddress> ShipAddresss { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<Province> Provinces { get; set; }

        public DbSet<City> Cities { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySQL(@"server=localhost;userid=root;password=btmoon781;database=homemanagedb;");
        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // 创建model
            builder.Entity<Brand>().HasKey(t => t.BrandID);
            builder.Entity<Category>().HasKey(t => t.CategoryID);
            builder.Entity<OrderDetail>().HasKey(t => t.OrderDetailID);
            builder.Entity<Order>().HasKey(t => t.OrderID);
            builder.Entity<Product>().HasKey(t => t.ProductID);
            builder.Entity<ShipAddress>().HasKey(t => t.AddressID);
            builder.Entity<CartItem>().HasKey(t => t.CartID);
            builder.Entity<ApplicationUser>().HasKey(t => t.Id);
            builder.Entity<ProductImage>().HasKey(t => t.ImageID);
            base.OnModelCreating(builder);
        }
    }
}
