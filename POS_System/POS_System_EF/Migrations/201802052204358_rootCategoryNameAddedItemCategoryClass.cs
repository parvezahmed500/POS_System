namespace POS_System_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rootCategoryNameAddedItemCategoryClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ItemCategories", "RootCategoryName", c => c.String());
            AlterColumn("dbo.ItemCategories", "RootCategoryId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ItemCategories", "RootCategoryId", c => c.Int(nullable: false));
            DropColumn("dbo.ItemCategories", "RootCategoryName");
        }
    }
}
