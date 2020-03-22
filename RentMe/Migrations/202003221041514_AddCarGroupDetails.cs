namespace RentMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCarGroupDetails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarGroupDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumberOfSeats = c.Int(nullable: false),
                        NumberOfDoors = c.Int(nullable: false),
                        NumberOfLargeBags = c.Int(nullable: false),
                        IsAC = c.Boolean(nullable: false),
                        Transmission = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.CarGroups", "CarGroupDetailsId", c => c.Int(nullable: false));
            CreateIndex("dbo.CarGroups", "CarGroupDetailsId");
            AddForeignKey("dbo.CarGroups", "CarGroupDetailsId", "dbo.CarGroupDetails", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CarGroups", "CarGroupDetailsId", "dbo.CarGroupDetails");
            DropIndex("dbo.CarGroups", new[] { "CarGroupDetailsId" });
            DropColumn("dbo.CarGroups", "CarGroupDetailsId");
            DropTable("dbo.CarGroupDetails");
        }
    }
}
