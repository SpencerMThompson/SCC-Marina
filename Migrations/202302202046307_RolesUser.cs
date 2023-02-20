namespace SCC_Marina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RolesUser : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserRoles", "RoleId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserRoles", "RoleId", c => c.Int(nullable: false));
        }
    }
}
