namespace POS_System_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Code = c.String(nullable: false, maxLength: 12),
                        ContactNo = c.String(nullable: false, maxLength: 11),
                        Email = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        ContactNo = c.String(nullable: false, maxLength: 11),
                        JoiningDate = c.DateTime(nullable: false),
                        Code = c.String(nullable: false, maxLength: 12),
                        Image = c.Binary(nullable: false),
                        EmergencyContactNo = c.String(),
                        FathersName = c.String(nullable: false, maxLength: 50),
                        MothersName = c.String(nullable: false, maxLength: 50),
                        NID = c.String(nullable: false, maxLength: 17),
                        Reference = c.String(),
                        PresentAddress = c.String(nullable: false, maxLength: 250),
                        PermanentAddress = c.String(nullable: false, maxLength: 250),
                        Email = c.String(),
                        OutletId = c.Int(),
                        OrganizationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId, cascadeDelete: true)
                .ForeignKey("dbo.Outlets", t => t.OutletId)
                .Index(t => t.OutletId)
                .Index(t => t.OrganizationId);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Code = c.String(nullable: false, maxLength: 12),
                        Logo = c.Binary(),
                        Address = c.String(nullable: false, maxLength: 250),
                        ContactNo = c.String(nullable: false, maxLength: 11),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Outlets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Code = c.String(nullable: false, maxLength: 12),
                        Address = c.String(nullable: false, maxLength: 250),
                        ContactNo = c.String(nullable: false, maxLength: 11),
                        OrganizationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId, cascadeDelete: true)
                .Index(t => t.OrganizationId);
            
            CreateTable(
                "dbo.ItemCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Code = c.String(nullable: false, maxLength: 12),
                        Description = c.String(),
                        RootCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        CostPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SalePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Code = c.String(nullable: false),
                        Description = c.String(),
                        ItemCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ItemCategories", t => t.ItemCategoryId, cascadeDelete: true)
                .Index(t => t.ItemCategoryId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        Code = c.String(nullable: false, maxLength: 12),
                        ContactNo = c.String(nullable: false, maxLength: 11),
                        Email = c.String(),
                        Address = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "ItemCategoryId", "dbo.ItemCategories");
            DropForeignKey("dbo.Employees", "OutletId", "dbo.Outlets");
            DropForeignKey("dbo.Outlets", "OrganizationId", "dbo.Organizations");
            DropForeignKey("dbo.Employees", "OrganizationId", "dbo.Organizations");
            DropIndex("dbo.Items", new[] { "ItemCategoryId" });
            DropIndex("dbo.Outlets", new[] { "OrganizationId" });
            DropIndex("dbo.Employees", new[] { "OrganizationId" });
            DropIndex("dbo.Employees", new[] { "OutletId" });
            DropTable("dbo.Suppliers");
            DropTable("dbo.Items");
            DropTable("dbo.ItemCategories");
            DropTable("dbo.Outlets");
            DropTable("dbo.Organizations");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
        }
    }
}
