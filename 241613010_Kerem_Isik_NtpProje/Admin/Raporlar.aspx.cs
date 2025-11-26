using NtpProje_Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _241613010_Kerem_Isik_NtpProje.Admin
{
    public partial class Raporlar : System.Web.UI.Page
    {
        CategoryManager categoryManager = new CategoryManager();

        // Ön yüze (ASPX) veri taşımak için public bir özellik tanımlıyoruz
        public string ChartData = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadReport();
            }
        }

        private void LoadReport()
        {
            // 1. Business katmanı aracılığıyla Stored Procedure'ü çağır
            var reportData = categoryManager.GetCategoryProjectCounts();

            // 2. Veriyi GridView'e bağla (Tablo görünümü)
            gvReport.DataSource = reportData;
            gvReport.DataBind();

            // 3. Veriyi Google Charts formatına çevir (Grafik görünümü)
            // Beklenen JS Formatı: ['Web Tasarım', 5], ['Grafik', 3]
            StringBuilder sb = new StringBuilder();

            foreach (var item in reportData)
            {
                sb.Append($"['{item.CategoryName}', {item.ProjectCount}],");
            }

            // Sondaki virgülü temizle ve değişkene ata
            ChartData = sb.ToString().TrimEnd(',');
        }
    }
}