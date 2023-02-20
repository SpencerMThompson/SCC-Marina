namespace SCC_Marina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Boats", "BoatType", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Boats", "Registration", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Boats", "BoatLength", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Boats", "Manufacturer", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Boats", "Year", c => c.String(nullable: false, maxLength: 4));
            AlterColumn("dbo.Boats", "NumberOfEngines", c => c.String(maxLength: 10));
            AlterColumn("dbo.Boats", "FuelType", c => c.String(maxLength: 25));
            AlterColumn("dbo.Boats", "KeelDepth", c => c.String(maxLength: 10));
            AlterColumn("dbo.Boats", "NumberOfSails", c => c.String(maxLength: 10));
            AlterColumn("dbo.Boats", "MotorType", c => c.String(maxLength: 25));
            AlterColumn("dbo.Customers", "FName", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Customers", "LName", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Customers", "Address", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Customers", "Phone", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.Leases", "LeaseType", c => c.String(nullable: false, maxLength: 25));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Leases", "LeaseType", c => c.String());
            AlterColumn("dbo.Customers", "Phone", c => c.String());
            AlterColumn("dbo.Customers", "Address", c => c.String());
            AlterColumn("dbo.Customers", "LName", c => c.String());
            AlterColumn("dbo.Customers", "FName", c => c.String());
            AlterColumn("dbo.Boats", "MotorType", c => c.String());
            AlterColumn("dbo.Boats", "NumberOfSails", c => c.String());
            AlterColumn("dbo.Boats", "KeelDepth", c => c.String());
            AlterColumn("dbo.Boats", "FuelType", c => c.String());
            AlterColumn("dbo.Boats", "NumberOfEngines", c => c.String());
            AlterColumn("dbo.Boats", "Year", c => c.String());
            AlterColumn("dbo.Boats", "Manufacturer", c => c.String());
            AlterColumn("dbo.Boats", "BoatLength", c => c.String());
            AlterColumn("dbo.Boats", "Registration", c => c.String());
            AlterColumn("dbo.Boats", "BoatType", c => c.String());
        }
    }
}
