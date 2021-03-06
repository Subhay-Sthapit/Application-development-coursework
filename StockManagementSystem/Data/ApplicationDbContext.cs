using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using StockManagementSystem.Models;

namespace StockManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<StockManagementSystem.Models.Category> Category { get; set; }
        public DbSet<StockManagementSystem.Models.Product> Product { get; set; }
        public DbSet<StockManagementSystem.Models.ProductStock> ProductStock { get; set; }
        public DbSet<StockManagementSystem.Models.Role> Role { get; set; }
        public DbSet<StockManagementSystem.Models.Customer> Customer { get; set; }


    }
}
