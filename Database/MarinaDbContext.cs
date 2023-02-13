using SCC_Marina.Entities;
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}