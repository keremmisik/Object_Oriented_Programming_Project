namespace NtpProje_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.abouts",
                c => new
                    {
                        AboutID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 200),
                        Summary = c.String(maxLength: 500),
                        MainDescription = c.String(),
                        TeamSectionSubtitle = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.AboutID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.portfolios",
                c => new
                    {
                        PortfolioID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 150),
                        Description = c.String(),
                        ThumbnailPath = c.String(maxLength: 250),
                        LargeImagePath = c.String(maxLength: 250),
                        WorkDate = c.DateTime(nullable: false),
                        Client = c.String(maxLength: 150),
                        Technologies = c.String(maxLength: 250),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PortfolioID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.contactinfoes",
                c => new
                    {
                        ContactInfoID = c.Int(nullable: false, identity: true),
                        PageDescription = c.String(maxLength: 500),
                        Address = c.String(maxLength: 300),
                        Phone = c.String(maxLength: 50),
                        Email = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.ContactInfoID);
            
            CreateTable(
                "dbo.contactmessages",
                c => new
                    {
                        MessageID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 100),
                        LastName = c.String(maxLength: 100),
                        Email = c.String(maxLength: 150),
                        Subject = c.String(maxLength: 200),
                        Message = c.String(),
                        SubmissionDate = c.DateTime(nullable: false),
                        IsRead = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MessageID);
            
            CreateTable(
                "dbo.news",
                c => new
                    {
                        NewsID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 200),
                        Summary = c.String(maxLength: 500),
                        FullContent = c.String(),
                        ImagePath = c.String(maxLength: 250),
                        PublishDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.NewsID);
            
            CreateTable(
                "dbo.services",
                c => new
                    {
                        ServiceID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 150),
                        Subtitle = c.String(maxLength: 250),
                        Description = c.String(maxLength: 500),
                        IconClass = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ServiceID);
            
            CreateTable(
                "dbo.Sliders",
                c => new
                    {
                        SliderID = c.Int(nullable: false, identity: true),
                        ImagePath = c.String(maxLength: 250),
                        Title = c.String(maxLength: 150),
                        Line1 = c.String(maxLength: 100),
                        Line2 = c.String(maxLength: 100),
                        Line3 = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.SliderID);
            
            CreateTable(
                "dbo.teammembers",
                c => new
                    {
                        TeamMemberID = c.Int(nullable: false, identity: true),
                        FullName = c.String(maxLength: 100),
                        Position = c.String(maxLength: 100),
                        ImagePath = c.String(maxLength: 250),
                        Biography = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.TeamMemberID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.portfolios", "CategoryID", "dbo.Categories");
            DropIndex("dbo.portfolios", new[] { "CategoryID" });
            DropTable("dbo.teammembers");
            DropTable("dbo.Sliders");
            DropTable("dbo.services");
            DropTable("dbo.news");
            DropTable("dbo.contactmessages");
            DropTable("dbo.contactinfoes");
            DropTable("dbo.portfolios");
            DropTable("dbo.Categories");
            DropTable("dbo.abouts");
        }
    }
}
