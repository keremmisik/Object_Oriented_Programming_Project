using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NtpProje_Business;

namespace _241613010_Kerem_Isik_NtpProje
{
    public partial class calismalarimiz : System.Web.UI.Page
    {
        CategoryManager categoryManager = new CategoryManager();
        PortfolioManager portfolioManager = new PortfolioManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }

        private void BindData()
        {
            // 1. Kategorileri Getir (Filtre için)
            var categories = categoryManager.GetActiveCategoriesOrdered();
            rptCategories.DataSource = categories;
            rptCategories.DataBind();

            // 2. Tüm Projeleri Getir (Listeleme için)
            // Kategori bilgisiyle (Include) gelmesi önemli!
            var portfolios = portfolioManager.GetActivePortfoliosWithCategory();
            rptPortfolios.DataSource = portfolios;
            rptPortfolios.DataBind();
        }
    }
}