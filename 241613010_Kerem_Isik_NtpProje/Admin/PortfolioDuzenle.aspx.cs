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
    public partial class PortfolioDuzenle : System.Web.UI.Page
    {
        PortfolioManager portfolioManager = new PortfolioManager();
        CategoryManager categoryManager = new CategoryManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Sayfa ilk yüklendiğinde DropDownList'i doldurmak zorundayız.
                BindCategories();

                if (Request.QueryString["ID"] != null)
                {
                    int portfolioId = Convert.ToInt32(Request.QueryString["ID"]);
                    LoadPortfolioData(portfolioId); // Formu doldurma metodunu çağır
                }
                else
                {
                    Response.Redirect("PortfolioListele.aspx");
                }
            }
        }

        // DropDownList'i CategoryManager'dan gelen verilerle dolduran metot (Ekle sayfasıyla aynı)
        private void BindCategories()
        {
            var categories = categoryManager.GetAllCategories();
            ddlCategory.DataSource = categories;
            ddlCategory.DataTextField = "CategoryName";
            ddlCategory.DataValueField = "CategoryID";
            ddlCategory.DataBind();
            ddlCategory.Items.Insert(0, new ListItem("--- Kategori Seçin ---", "0"));
        }


        // Formu, veritabanından gelen bilgilerle dolduran metot
        private void LoadPortfolioData(int id)
        {
            // Business katmanındaki özel metodu kullanıyoruz (Kategori bilgisini de getiren)
            portfolio portfolio = portfolioManager.GetPortfolioByIdWithCategory(id);

            if (portfolio != null)
            {
                // 1. Textbox'ları Doldur
                hdnPortfolioID.Value = portfolio.PortfolioID.ToString();
                txtTitle.Text = portfolio.Title;
                txtDescription.Text = portfolio.Description;
                txtClient.Text = portfolio.Client;
                txtTechnologies.Text = portfolio.Technologies;
                txtThumbnailPath.Text = portfolio.ThumbnailPath;
                txtLargeImagePath.Text = portfolio.LargeImagePath;
                chkIsActive.Checked = portfolio.IsActive;

                // Tarih formatını HTML'in anladığı formata (yyyy-MM-dd) dönüştür
                txtWorkDate.Text = portfolio.WorkDate.ToString("yyyy-MM-dd");

                // 2. KRİTİK ADIM: DropDownList'i doğru değere ayarla
                // Veritabanındaki CategoryID'yi DDL'de seçili yap
                ddlCategory.SelectedValue = portfolio.CategoryID.ToString();
            }
            else
            {
                Response.Redirect("PortfolioListele.aspx");
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // İş Kuralı: Kategori seçimi yapılmalı
                if (ddlCategory.SelectedValue == "0") return;

                // 1. Güncellenecek nesneyi ID'sine göre bul
                int portfolioId = Convert.ToInt32(hdnPortfolioID.Value);
                portfolio portfolioToUpdate = portfolioManager.GetPortfolioById(portfolioId);

                // 2. Nesnenin içini formdaki YENİ verilerle güncelle
                portfolioToUpdate.Title = txtTitle.Text;
                portfolioToUpdate.Description = txtDescription.Text;
                portfolioToUpdate.Client = txtClient.Text;
                portfolioToUpdate.Technologies = txtTechnologies.Text;
                portfolioToUpdate.ThumbnailPath = txtThumbnailPath.Text;
                portfolioToUpdate.LargeImagePath = txtLargeImagePath.Text;
                portfolioToUpdate.IsActive = chkIsActive.Checked;

                if (DateTime.TryParse(txtWorkDate.Text, out DateTime workDate))
                {
                    portfolioToUpdate.WorkDate = workDate;
                }

                // 3. Foreign Key'i (Kategori ID) güncelle
                portfolioToUpdate.CategoryID = Convert.ToInt32(ddlCategory.SelectedValue);

                // 4. Business katmanında güncelleme işlemini yap
                portfolioManager.UpdatePortfolio(portfolioToUpdate);

                // 5. Başarılıysa, listeye yönlendir.
                Response.Redirect("PortfolioListele.aspx");
            }
            catch (Exception ex)
            {
                // Hata yönetimi
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("PortfolioListele.aspx");
        }
    }
}