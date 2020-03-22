namespace RentMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhotoUrlToCarGroupDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CarGroupDetails", "PhotoUrl", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CarGroupDetails", "PhotoUrl");
        }
    }
}
