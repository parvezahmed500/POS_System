namespace POS_System_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class expense_item_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExpenseItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Description = c.String(),
                        ExpenseCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExpenseCategories", t => t.ExpenseCategoryId, cascadeDelete: true)
                .Index(t => t.ExpenseCategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExpenseItems", "ExpenseCategoryId", "dbo.ExpenseCategories");
            DropIndex("dbo.ExpenseItems", new[] { "ExpenseCategoryId" });
            DropTable("dbo.ExpenseItems");
        }
    }
}
