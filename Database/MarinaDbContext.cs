using SCC_Marina.Entities;
using SCC_Marina.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SCC_Marina.Database
{
    public class MarinaDbContext : DbContext
    {
        public MarinaDbContext() : base("MarinaSystemDb")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Lease> Leases { get; set; }
        public DbSet<Dock> Docks { get; set; }
        public DbSet<Boat> Boats { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}