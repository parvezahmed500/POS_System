namespace POS_System_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class expense_category_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExpenseCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        Code = c.String(nullable: false, maxLength: 12),
                        Description = c.String(),
                        RootCategoryId = c.Int(nullable: false),
                        RootCategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ExpenseCategories");
        }
    }
}
