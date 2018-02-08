namespace POS_System_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsDelete_added_in_organization : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Organizations", "IsDelete", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Organizations", "IsDelete");
        }
    }
}
