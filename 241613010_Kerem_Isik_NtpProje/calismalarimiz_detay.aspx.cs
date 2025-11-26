using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NtpProje_Business;
using NtpProje_Entities;

namespace _241613010_Kerem_Isik_NtpProje
{
    public partial class calismalarimiz_detay : System.Web.UI.Page
    {
        PortfolioManager portfolioManager = new PortfolioManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["ID"] != null)
                {
                    int id = Convert.ToInt32(Request.QueryString["ID"]);
                    LoadPortfolio(id);
                }
                else
                {
                    Response.Redirect("calismalarimiz.aspx");
                }
            }
        }

        private void LoadPortfolio(int id)
        {
            // Kategori bilgisiyle birlikte çekiyoruz
            portfolio p = portfolioManager.GetPortfolioByIdWithCategory(id);

            if (p != null && p.IsActive)
            {
                litMainTitle.Text = p.Title;
                litSubTitle.Text = p.Title;
                litCategory.Text = p.Category.CategoryName;
                litDate.Text = p.WorkDate.ToString("dd MMMM yyyy");
                litDescription.Text = p.Description;
                litClient.Text = p.Client;
                litTech.Text = p.Technologies;
                imgBig.ImageUrl = p.LargeImagePath;
            }
            else
            {
                Response.Redirect("calismalarimiz.aspx");
            }
        }
    }
}