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
    public partial class CategoryEkle : System.Web.UI.Page
    {
        CategoryManager categoryManager = new CategoryManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            // Bu sayfada Page_Load'da işlem gerekmiyor.
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Entities katmanından yeni Category nesnesi oluştur.
                Category newCategory = new Category();

                // 2. Nesnenin içini formdaki veriyle doldur.
                newCategory.CategoryName = txtName.Text;

                // 3. Business katmanına git ve "AddCategory" metodunu çalıştır.
                categoryManager.AddCategory(newCategory);

                // 4. Ekleme başarılıysa, listeleme sayfasına yönlendir.
                Response.Redirect("CategoryListele.aspx");
            }
            catch (Exception ex)
            {
                // Hata mesajı yönetimi
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            // Kullanıcıyı LİSTE sayfasına geri yönlendir.
            Response.Redirect("CategoryListele.aspx");
        }
    }
}