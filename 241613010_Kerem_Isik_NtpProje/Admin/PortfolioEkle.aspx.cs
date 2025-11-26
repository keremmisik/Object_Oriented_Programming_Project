using NtpProje_Business;
using NtpProje_Entities;
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
    public partial class PortfolioEkle : System.Web.UI.Page
    {
        // Manager'ları çağırıyoruz
        PortfolioManager portfolioManager = new PortfolioManager();
        CategoryManager categoryManager = new CategoryManager(); // Kategorileri çekmek için!

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCategories(); // Sayfa ilk yüklendiğinde DropDownList'i doldur
            }
        }

        // DropDownList'i CategoryManager'dan gelen verilerle dolduran metot
        private void BindCategories()
        {
            // Business katmanından tüm kategorileri çek
            var categories = categoryManager.GetAllCategories();

            // DropDownList'i doldurma:
            ddlCategory.DataSource = categories;

            // Kullanıcıya görünecek metin (Görünen Kısım)
            ddlCategory.DataTextField = "CategoryName";

            // Veritabanına kaydedilecek değer (Arka Plan Kısım)
            ddlCategory.DataValueField = "CategoryID";

            ddlCategory.DataBind();

            // Kullanıcıya bir seçim yapması gerektiğini bildiren ilk öğeyi ekle
            ddlCategory.Items.Insert(0, new ListItem("--- Kategori Seçin ---", "0"));
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kategorinin seçildiğini kontrol et (İş Kuralı)
                if (ddlCategory.SelectedValue == "0")
                {
                    // Hata mesajı gösterilebilir
                    return;
                }

                // 2. Yeni Portfolio nesnesi oluştur.
                portfolio newPortfolio = new portfolio();

                // 3. Nesnenin içini formdaki verilerle doldur.
                newPortfolio.Title = txtTitle.Text;
                newPortfolio.Description = txtDescription.Text;
                newPortfolio.Client = txtClient.Text;
                newPortfolio.Technologies = txtTechnologies.Text;
                newPortfolio.ThumbnailPath = txtThumbnailPath.Text;
                newPortfolio.LargeImagePath = txtLargeImagePath.Text;
                newPortfolio.IsActive = chkIsActive.Checked;

                // Tarih dönüşümünü kontrol et
                if (DateTime.TryParse(txtWorkDate.Text, out DateTime workDate))
                {
                    newPortfolio.WorkDate = workDate;
                }
                else
                {
                    newPortfolio.WorkDate = DateTime.Now; // Tarih girilmezse o anki tarihi kullan
                }

                // *** FOREIGN KEY BAĞLANTISI ***
                // DropDownList'ten seçilen CategoryID'yi Portfolio nesnesine kaydet.
                newPortfolio.CategoryID = Convert.ToInt32(ddlCategory.SelectedValue);

                // 4. Business katmanına git ve kaydet.
                portfolioManager.AddPortfolio(newPortfolio);

                // 5. Başarılıysa, listeleme sayfasına yönlendir.
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