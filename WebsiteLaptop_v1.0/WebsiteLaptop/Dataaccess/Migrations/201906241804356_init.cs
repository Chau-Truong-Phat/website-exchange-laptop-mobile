namespace Dataaccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductID = c.String(nullable: false, maxLength: 30),
                        ProductName = c.String(nullable: false, maxLength: 200),
                        CPU = c.String(nullable: false, maxLength: 100),
                        RAM = c.String(nullable: false, maxLength: 100),
                        HardDrive = c.String(nullable: false, maxLength: 100),
                        VideoCard = c.String(maxLength: 100),
                        OperatingSystem = c.String(nullable: false, maxLength: 100),
                        Weight = c.Double(nullable: false),
                        Size = c.String(maxLength: 50),
                        Price = c.Double(nullable: false),
                        ImgName = c.String(),
                        ProducerID = c.String(nullable: false, maxLength: 10),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Category", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.Producer", t => t.ProducerID, cascadeDelete: true)
                .Index(t => t.ProducerID)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.OrderDetail",
                c => new
                    {
                        OrderID = c.String(nullable: false, maxLength: 40),
                        ProductID = c.String(nullable: false, maxLength: 30),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderID, t.ProductID })
                .ForeignKey("dbo.Order", t => t.OrderID, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderID = c.String(nullable: false, maxLength: 40),
                        CustomerID = c.String(maxLength: 40),
                        OrderDate = c.DateTime(nullable: false),
                        Total = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Customer", t => t.CustomerID)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustomerID = c.String(nullable: false, maxLength: 40),
                        CustomerName = c.String(nullable: false, maxLength: 200),
                        Address = c.String(nullable: false, maxLength: 200),
                        Phone = c.String(nullable: false, maxLength: 15),
                        IdentityNumber = c.String(nullable: false, maxLength: 15),
                        Email = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Producer",
                c => new
                    {
                        ProducerID = c.String(nullable: false, maxLength: 10),
                        ProducerName = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.ProducerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "ProducerID", "dbo.Producer");
            DropForeignKey("dbo.OrderDetail", "ProductID", "dbo.Product");
            DropForeignKey("dbo.OrderDetail", "OrderID", "dbo.Order");
            DropForeignKey("dbo.Order", "CustomerID", "dbo.Customer");
            DropForeignKey("dbo.Product", "CategoryID", "dbo.Category");
            DropIndex("dbo.Order", new[] { "CustomerID" });
            DropIndex("dbo.OrderDetail", new[] { "ProductID" });
            DropIndex("dbo.OrderDetail", new[] { "OrderID" });
            DropIndex("dbo.Product", new[] { "CategoryID" });
            DropIndex("dbo.Product", new[] { "ProducerID" });
            DropTable("dbo.Producer");
            DropTable("dbo.Customer");
            DropTable("dbo.Order");
            DropTable("dbo.OrderDetail");
            DropTable("dbo.Product");
            DropTable("dbo.Category");
        }
    }
}
