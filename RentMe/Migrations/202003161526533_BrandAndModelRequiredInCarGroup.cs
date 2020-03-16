namespace RentMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BrandAndModelRequiredInCarGroup : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CarGroups", "Brand", c => c.String(nullable: false));
            AlterColumn("dbo.CarGroups", "Model", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CarGroups", "Model", c => c.String());
            AlterColumn("dbo.CarGroups", "Brand", c => c.String());
        }
    }
}
