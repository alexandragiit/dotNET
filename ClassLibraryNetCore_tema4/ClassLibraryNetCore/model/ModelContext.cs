using ClassLibraryNetCore.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryNetCore.Model
{
    internal class ModelContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=skynet\\sqlexpress;Initial Catalog=EfCore2020;Integrated Security=True");
            //ChangeTracker.LazyLoadingEnabled = false;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
            .HasMany<Order>(o => o.Orders)
            .WithOne(c => c.Client);

            modelBuilder.Entity<OrderDetails>()
            .HasOne<Order>(od => od.Order).WithMany(o => o.OrderDetail);

            modelBuilder.Entity<Product>().HasMany<OrderDetails>(p => p.OrderDetails)
            .WithOne(od => od.Product);
        }
    }

}