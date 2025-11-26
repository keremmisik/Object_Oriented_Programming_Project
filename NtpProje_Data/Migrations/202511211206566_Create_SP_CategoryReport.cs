namespace NtpProje_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_SP_CategoryReport : DbMigration
    {
        public override void Up()
        {
            // Veritabanında 'GetCategoryProjectCounts' adında bir Prosedür oluşturuyoruz.
            // Bu sorgu: Kategorileri ve Projeleri birleştirir (JOIN), her kategoride kaç proje olduğunu sayar (COUNT).
            Sql(@"
            CREATE PROCEDURE GetCategoryProjectCounts
            AS
            BEGIN
                SELECT 
                    c.CategoryName, 
                    COUNT(p.PortfolioID) as ProjectCount
                FROM 
                    Categories c
                LEFT JOIN 
                    Portfolios p ON c.CategoryID = p.CategoryID
                GROUP BY 
                    c.CategoryName
            END
        ");
        }

        public override void Down()
        {
            // Eğer migration geri alınırsa prosedürü sil
            Sql("DROP PROCEDURE GetCategoryProjectCounts");
        }
    }
}
