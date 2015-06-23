namespace POSApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldAndDataAnotations : DbMigration
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
            
            DropTable("dbo.ProductModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProductModels",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false),
                        ProductPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID);
            
            DropTable("dbo.Products");
        }
    }
}
