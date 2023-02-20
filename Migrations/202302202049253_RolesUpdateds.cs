namespace SCC_Marina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RolesUpdateds : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Roles", "UserRole_UserRoleID", "dbo.UserRoles");
            DropIndex("dbo.Roles", new[] { "UserRole_UserRoleID" });
            AddColumn("dbo.UserRoles", "RoleId", c => c.Int(nullable: false));
            DropColumn("dbo.Roles", "UserRole_UserRoleID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Roles", "UserRole_UserRoleID", c => c.Int());
            DropColumn("dbo.UserRoles", "RoleId");
            CreateIndex("dbo.Roles", "UserRole_UserRoleID");
            AddForeignKey("dbo.Roles", "UserRole_UserRoleID", "dbo.UserRoles", "UserRoleID");
        }
    }
}
