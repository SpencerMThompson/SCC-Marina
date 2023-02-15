namespace SCC_Marina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Properties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "firstName", c => c.String(maxLength: 50));
            AddColumn("dbo.Users", "lastName", c => c.String(maxLength: 50));
            AddColumn("dbo.Users", "Emai", c => c.String());
            AlterColumn("dbo.Users", "Username", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Username", c => c.String());
            DropColumn("dbo.Users", "Emai");
            DropColumn("dbo.Users", "lastName");
            DropColumn("dbo.Users", "firstName");
        }
    }
}
