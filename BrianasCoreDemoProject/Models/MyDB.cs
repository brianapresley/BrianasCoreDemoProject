using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrianasCoreDemoProject.Models
{
    public class MyDB : DbContext {

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public MyDB(DbContextOptions options) : base(options) 
        {

        }
    }
}
