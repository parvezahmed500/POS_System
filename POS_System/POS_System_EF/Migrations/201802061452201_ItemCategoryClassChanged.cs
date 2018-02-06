namespace POS_System_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ItemCategoryClassChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ItemCategories", "CategoryId", c => c.Int());
            CreateIndex("dbo.ItemCategories", "CategoryId");
            AddForeignKey("dbo.ItemCategories", "CategoryId", "dbo.ItemCategories", "Id");
            DropColumn("dbo.ItemCategories", "RootCategoryId");
            DropColumn("dbo.ItemCategories", "RootCategoryName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ItemCategories", "RootCategoryName", c => c.String());
            AddColumn("dbo.ItemCategories", "RootCategoryId", c => c.Int());
            DropForeignKey("dbo.ItemCategories", "CategoryId", "dbo.ItemCategories");
            DropIndex("dbo.ItemCategories", new[] { "CategoryId" });
            DropColumn("dbo.ItemCategories", "CategoryId");
        }
    }
}
