namespace RentMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClientToRental : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentals", "ClientId", c => c.Int(nullable: false));
            CreateIndex("dbo.Rentals", "ClientId");
            AddForeignKey("dbo.Rentals", "ClientId", "dbo.Clients", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "ClientId", "dbo.Clients");
            DropIndex("dbo.Rentals", new[] { "ClientId" });
            DropColumn("dbo.Rentals", "ClientId");
        }
    }
}
