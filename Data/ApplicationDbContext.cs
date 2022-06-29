using Asm1670.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asm1670.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Book> Book { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedRole(builder);
            SeedCart(builder);
            SeedCustomer(builder);
            SeedBook(builder);
        }

        private void SeedRole(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "HANOI", Name = "Manager", NormalizedName = "MANAGER" },
                new IdentityRole { Id = "HCM", Name = "Customer", NormalizedName = "CUSTOMER" },
                new IdentityRole { Id = "DaNang", Name = "Admin", NormalizedName = "ADMIN" }

             );
        }
        private void SeedCart(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>().HasData(
                new Cart { Id = 1, Amount = 3 },
                new Cart { Id = 2, Amount = 3 },
                new Cart { Id = 3, Amount = 3 }
                );
        }
        private void SeedCustomer(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Bui Duc Cuong", Age = 20, Phone = "0843034237", Email = "cuongbuiqqq", Address = "Hai Duong" },
                new Customer { Id = 2, Name = "Bui Duc Cuong", Age = 20, Phone = "0843034237", Email = "cuongbuiqqq", Address = "Hai Duong" },
                new Customer { Id = 3, Name = "Bui Duc Cuong", Age = 20, Phone = "0843034237", Email = "cuongbuiqqq", Address = "Hai Duong" }
            );
        }
        private void SeedBook(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "Doraemon", Price = 13000, CustomerId = 1, CartId = 1 },
                new Book { Id = 2, Title = "Doraemon", Price = 13000, CustomerId = 2, CartId = 2 },
                new Book { Id = 3, Title = "Doraemon", Price = 13000, CustomerId = 3, CartId = 3 }
            );
        }
    }
}
