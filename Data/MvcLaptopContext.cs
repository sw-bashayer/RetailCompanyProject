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

        public DbSet<RetailCompanyProject.Models.Laptop> Laptop { get; set; }
        public DbSet<RetailCompanyProject.Models.Orders> Orders { get; set; }

}
