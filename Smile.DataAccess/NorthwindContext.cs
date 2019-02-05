using Microsoft.EntityFrameworkCore;
using Smile.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smile.DataAccess
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DELL-PC;Integrated Security=True;Database=Northwind;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>()
                 .HasKey(od => new { od.OrderID, od.ProductID });
              
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }


    }
}
