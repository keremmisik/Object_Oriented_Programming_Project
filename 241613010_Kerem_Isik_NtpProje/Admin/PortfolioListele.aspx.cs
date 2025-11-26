using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NtpProje_Business; // Business katmanımız
using NtpProje_Entities; // Entities katmanımız

namespace _241613010_Kerem_Isik_NtpProje.Admin
{
    public partial class PortfolioListele : System.Web.UI.Page
    {
        // Manager'ımızı çağırıyoruz
        PortfolioManager portfolioManager = new PortfolioManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindPortfolioGrid(); // Grid'i doldur
            }
        }

        private void BindPortfolioGrid()
        {
            // Business katmanındaki özel metodu kullanıyoruz:
            // İlişkili Kategori bilgisini de çekmeyi unutmamalıyız.
            var portfolios = portfolioManager.GetActivePortfoliosWithCategory();

            gvPortfolios.DataSource = portfolios;
            gvPortfolios.DataBind();
        }

        protected void gvPortfolios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // Tıklanan satırın ID'sini al
            int portfolioId = Convert.ToInt32(gvPortfolios.DataKeys[e.RowIndex].Value);

            // Business katmanına git ve sil
            portfolioManager.DeletePortfolio(portfolioId);

            // Silme işleminden sonra listeyi yenile
            BindPortfolioGrid();
        }
    }
}