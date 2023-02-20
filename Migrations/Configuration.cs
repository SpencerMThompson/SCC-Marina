namespace SCC_Marina.Migrations
{
    using SCC_Marina.Database;
    using SCC_Marina.Helpers;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SCC_Marina.Database.MarinaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SCC_Marina.Database.MarinaDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            this.SeedUsers(context);
        }

        private void SeedUsers(MarinaDbContext context)
        {
            var password = HashManager.HashPassword("Password123");

            if(!context.Users.Any(i => i.Username == "firstuser@gmail.com"))
            {
                context.Users.Add(new Entities.User
                {
                    Username = "firstuser@gmail.com",
                    Password = password
                }); 
            }

            context.SaveChanges();
        }
    }
}
