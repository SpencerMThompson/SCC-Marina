namespace SCC_Marina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoreClasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Boats",
                c => new
                    {
                        BoatID = c.Int(nullable: false, identity: true),
                        BoatType = c.String(),
                        Registration = c.String(),
                        BoatLength = c.String(),
                        Manufacturer = c.String(),
                        Year = c.String(),
                        NumberOfEngines = c.String(),
                        FuelType = c.String(),
                        KeelDepth = c.String(),
                        NumberOfSails = c.String(),
                        MotorType = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.BoatID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        FName = c.String(),
                        LName = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Docks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Location = c.String(nullable: false, maxLength: 50),
                        Electricity = c.Boolean(nullable: false),
                        Water = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Leases",
                c => new
                    {
                        LeaseId = c.Int(nullable: false, identity: true),
                        BoatId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        SlipId = c.Int(nullable: false),
                        LeaseType = c.String(),
                        Rate = c.Single(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        MonthlyPaymentDate = c.DateTime(),
                        RemainingBalance = c.Single(),
                        NumberOfDays = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.LeaseId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Leases");
            DropTable("dbo.Docks");
            DropTable("dbo.Customers");
            DropTable("dbo.Boats");
        }
    }
}
