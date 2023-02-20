namespace SCC_Marina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Prop : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Email", c => c.String());
            DropColumn("dbo.Users", "Emai");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Emai", c => c.String());
            DropColumn("dbo.Users", "Email");
        }
    }
}
