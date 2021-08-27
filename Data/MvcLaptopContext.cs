using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetailCompanyProject.Models;

    public class MvcLaptopContext : DbContext
    {
        public MvcLaptopContext (DbContextOptions<MvcLaptopContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<RetailCompanyProject.Models.Laptop>().HasData(
      new List<RetailCompanyProject.Models.Laptop>()
      {
        new Laptop {Id=1,Name="Lenevo", Color="Grey", Screen="13 inch", Quantity=30, ImageURL= "lenovo.jpg", Price=3510 },
        new Laptop {Id=2,Name="HP", Color="Natural Silver", Screen="14 inch", Quantity=40, ImageURL= "hp.png", Price=4100 },
        new Laptop {Id=3,Name="Apple MacBook Air 2020", Color="S.Grey", Screen="13 inch", Quantity=50, ImageURL= "MacBook.jpeg", Price=4899 },
        new Laptop {Id=4,Name="Asus X415", Color="Silver", Screen="14 inch", Quantity=25, ImageURL= "asus.jpeg", Price=2399 },
        new Laptop {Id=5,Name="Dell XPS", Color="Silver", Screen="13 inch", Quantity=10, ImageURL= "dell.jpeg", Price=5759 }

      }
      );
    base.OnModelCreating(modelBuilder);
  }

        public DbSet<RetailCompanyProject.Models.Laptop> Laptop { get; set; }
        public DbSet<RetailCompanyProject.Models.Orders> Orders { get; set; }

}
