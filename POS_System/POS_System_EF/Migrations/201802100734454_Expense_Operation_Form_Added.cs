namespace POS_System_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Expense_Operation_Form_Added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExpenseOperations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExpenseName = c.String(nullable: false, maxLength: 150),
                        Qty = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Paid = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Due = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        Remarks = c.String(maxLength: 250),
                        EmployeeName = c.String(nullable: false, maxLength: 150),
                        OrganizationName = c.String(nullable: false, maxLength: 150),
                        OutletName = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ExpenseOperations");
        }
    }
}
