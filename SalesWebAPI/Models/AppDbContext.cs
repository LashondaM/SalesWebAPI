using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebAPI.Models
{
    public class AppDbContext : DbContext {

        //DbSet collections go here
        public virtual DbSet<Customer> Customers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder) { }
    }
}
