namespace RentMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCarCarGroupAndRentalModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        Model = c.String(),
                        DayPrice = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarGroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CarGroups", t => t.CarGroupId, cascadeDelete: true)
                .Index(t => t.CarGroupId);
            
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarId = c.Int(nullable: false),
                        PickupDate = c.DateTime(nullable: false),
                        ReturnDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.CarId, cascadeDelete: true)
                .Index(t => t.CarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "CarId", "dbo.Cars");
            DropForeignKey("dbo.Cars", "CarGroupId", "dbo.CarGroups");
            DropIndex("dbo.Rentals", new[] { "CarId" });
            DropIndex("dbo.Cars", new[] { "CarGroupId" });
            DropTable("dbo.Rentals");
            DropTable("dbo.Cars");
            DropTable("dbo.CarGroups");
        }
    }
}
