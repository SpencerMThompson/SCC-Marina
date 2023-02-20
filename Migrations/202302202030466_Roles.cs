namespace SCC_Marina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Roles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false),
                        RoleName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RoleId)
                .ForeignKey("dbo.UserRoles", t => t.RoleId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        UserRoleID = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserRoleID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Roles", "RoleId", "dbo.UserRoles");
            DropIndex("dbo.Roles", new[] { "RoleId" });
            DropTable("dbo.UserRoles");
            DropTable("dbo.Roles");
        }
    }
}
