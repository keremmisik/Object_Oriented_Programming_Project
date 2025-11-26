namespace NtpProje_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Admin_Control_Fields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Order", c => c.Int(nullable: false));
            AddColumn("dbo.Categories", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.portfolios", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.news", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.services", "Order", c => c.Int(nullable: false));
            AddColumn("dbo.services", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Sliders", "Order", c => c.Int(nullable: false));
            AddColumn("dbo.Sliders", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.teammembers", "Order", c => c.Int(nullable: false));
            AddColumn("dbo.teammembers", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.teammembers", "IsActive");
            DropColumn("dbo.teammembers", "Order");
            DropColumn("dbo.Sliders", "IsActive");
            DropColumn("dbo.Sliders", "Order");
            DropColumn("dbo.services", "IsActive");
            DropColumn("dbo.services", "Order");
            DropColumn("dbo.news", "IsActive");
            DropColumn("dbo.portfolios", "IsActive");
            DropColumn("dbo.Categories", "IsActive");
            DropColumn("dbo.Categories", "Order");
        }
    }
}
