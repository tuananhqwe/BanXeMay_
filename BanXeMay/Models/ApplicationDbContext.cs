using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
namespace BanXeMay.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "SUZUKI", DisplayOrder = 1 },
            new Category { Id = 2, Name = "ZAMAHA", DisplayOrder = 2 },
            new Category { Id = 3, Name = "HONDA", DisplayOrder = 3 });
            //seed data to table Product
            modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "RAIDER R150", Price = 460000000, CategoryId = 1 },
            new Product { Id = 2, Name = "BURGMAN STREET 125", Price = 46000000, CategoryId = 1 },
            new Product { Id = 3, Name = "V-STROM 250SX", Price = 134000000, CategoryId = 1 },
            new Product { Id = 4, Name = "SATRIA F150", Price = 50000000, CategoryId = 1 },
            new Product { Id = 5, Name = "LEXI", Price = 47912344, CategoryId = 2 },
            new Product { Id = 6, Name = "GRANDE", Price = 460000000, CategoryId = 2 },
            new Product { Id = 7, Name = "FREEGO", Price = 300000000, CategoryId = 2 },
            new Product { Id = 8, Name = "NVX", Price = 34000000, CategoryId = 2 },
            new Product { Id = 9, Name = "Wave Alpha", Price = 22000000, CategoryId = 3 },
            new Product { Id = 10, Name = "SH350i ", Price = 1450000000, CategoryId = 3 },
            new Product { Id = 11, Name = "Air Blade 2025", Price = 57500000, CategoryId = 3 },
            new Product { Id = 12, Name = "LEAD 125", Price = 42500000, CategoryId = 3 });
        }
    }
}
