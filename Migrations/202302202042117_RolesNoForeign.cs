namespace SCC_Marina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RolesNoForeign : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Roles", "RoleId", "dbo.UserRoles");
            DropIndex("dbo.Roles", new[] { "RoleId" });
            DropPrimaryKey("dbo.Roles");
            AddColumn("dbo.Roles", "UserRole_UserRoleID", c => c.Int());
            AlterColumn("dbo.Roles", "RoleId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Roles", "RoleId");
            CreateIndex("dbo.Roles", "UserRole_UserRoleID");
            AddForeignKey("dbo.Roles", "UserRole_UserRoleID", "dbo.UserRoles", "UserRoleID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Roles", "UserRole_UserRoleID", "dbo.UserRoles");
            DropIndex("dbo.Roles", new[] { "UserRole_UserRoleID" });
            DropPrimaryKey("dbo.Roles");
            AlterColumn("dbo.Roles", "RoleId", c => c.Int(nullable: false));
            DropColumn("dbo.Roles", "UserRole_UserRoleID");
            AddPrimaryKey("dbo.Roles", "RoleId");
            CreateIndex("dbo.Roles", "RoleId");
            AddForeignKey("dbo.Roles", "RoleId", "dbo.UserRoles", "UserRoleID");
        }
    }
}
