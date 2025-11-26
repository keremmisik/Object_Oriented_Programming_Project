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
    public partial class CategoryDuzenle : System.Web.UI.Page
    {
        CategoryManager categoryManager = new CategoryManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Sayfa ilk kez yükleniyorsa
            {
                // URL'den (?ID=...) gelen ID'yi al
                if (Request.QueryString["ID"] != null)
                {
                    int categoryId = Convert.ToInt32(Request.QueryString["ID"]);
                    LoadCategoryData(categoryId); // Formu doldurma metodunu çağır
                }
                else
                {
                    // ID yoksa, listeye geri yolla
                    Response.Redirect("CategoryListele.aspx");
                }
            }
        }

        // Formu, veritabanından gelen bilgilerle dolduran metot
        private void LoadCategoryData(int id)
        {
            // Business katmanına git ve ID'ye göre kategoriyi bul
            Category category = categoryManager.GetCategoryById(id);

            if (category != null)
            {
                // Formdaki kontrollere verileri ata
                hdnCategoryID.Value = category.CategoryID.ToString(); // ID'yi gizli alanda sakla
                txtName.Text = category.CategoryName; // Kategori adını forma yaz
            }
            else
            {
                // Kategori bulunamazsa listeye geri yolla
                Response.Redirect("CategoryListele.aspx");
            }
        }

        // "Güncelle" butonuna tıklandığında çalışacak metot
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Güncellenecek nesneyi ID'sine göre bul
                int categoryId = Convert.ToInt32(hdnCategoryID.Value);
                Category categoryToUpdate = categoryManager.GetCategoryById(categoryId);

                // 2. Nesnenin CategoryName alanını formdaki YENİ veriyle güncelle
                categoryToUpdate.CategoryName = txtName.Text;

                // 3. Business katmanına git ve "UpdateCategory" metodunu çalıştır.
                categoryManager.UpdateCategory(categoryToUpdate);

                // 4. Güncelleme başarılıysa, kullanıcıyı tekrar LİSTE sayfasına yönlendir.
                Response.Redirect("CategoryListele.aspx");
            }
            catch (Exception ex)
            {
                // Hata yönetimi
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            // Kullanıcıyı LİSTE sayfasına geri yönlendir.
            Response.Redirect("CategoryListele.aspx");
        }
    }
}