namespace POS_System_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class itemcategory_class_change : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ItemCategories", "CategoryId", "dbo.ItemCategories");
            DropIndex("dbo.ItemCategories", new[] { "CategoryId" });
            AddColumn("dbo.ItemCategories", "RootCategoryId", c => c.Int(nullable: false));
            AddColumn("dbo.ItemCategories", "RootCategoryName", c => c.String());
            DropColumn("dbo.ItemCategories", "CategoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ItemCategories", "CategoryId", c => c.Int());
            DropColumn("dbo.ItemCategories", "RootCategoryName");
            DropColumn("dbo.ItemCategories", "RootCategoryId");
            CreateIndex("dbo.ItemCategories", "CategoryId");
            AddForeignKey("dbo.ItemCategories", "CategoryId", "dbo.ItemCategories", "Id");
        }
    }
}
