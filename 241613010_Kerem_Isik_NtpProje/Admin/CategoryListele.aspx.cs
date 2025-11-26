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
    public partial class CategoryListele : System.Web.UI.Page
    {
        // CategoryManager'ımızı çağırıyoruz
        CategoryManager categoryManager = new CategoryManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCategoryGrid(); // Grid'i doldur
            }
        }

        private void BindCategoryGrid()
        {
            // Business katmanına git ve "Tüm Kategorileri Getir" metodunu çalıştır.
            var categories = categoryManager.GetAllCategories();

            gvCategories.DataSource = categories;
            gvCategories.DataBind();
        }

        protected void gvCategories_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // Tıklanan satırın ID'sini al
            int categoryId = Convert.ToInt32(gvCategories.DataKeys[e.RowIndex].Value);

            // Business katmanına git ve sil
            categoryManager.DeleteCategory(categoryId);

            // Silme işleminden sonra listeyi yenile
            BindCategoryGrid();
        }
    }
}