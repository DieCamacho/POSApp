namespace POSApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(maxLength: 60),
                        ProductPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.DateTime(nullable: false),
                        Rating = c.String(maxLength: 5),
                    })
                .PrimaryKey(t => t.ProductID);
            
            CreateTable(
                "dbo.UnitOfMeasurements",
                c => new
                    {
                        MeasureID = c.Int(nullable: false, identity: true),
                        MeasureCode = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.MeasureID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UnitOfMeasurements");
            DropTable("dbo.Products");
        }
    }
}
