using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NtpProje_Business; // Business katmanımızı buraya çağırıyoruz!
using NtpProje_Entities;

namespace _241613010_Kerem_Isik_NtpProje.Admin
{
    public partial class SliderListele : System.Web.UI.Page
    {
        // Business katmanındaki Manager'ımızı çağırıyoruz
        SliderManager sliderManager = new SliderManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Sayfa ilk kez yükleniyorsa
            {
                BindSliderGrid(); // Grid'i (tabloyu) doldur
            }
        }

        // Grid'i (tabloyu) veritabanından dolduran metot
        private void BindSliderGrid()
        {
            // Business katmanına git ve "Tüm Slider'ları Getir" metodunu çalıştır.
            var sliders = sliderManager.GetAllSliders();

            gvSliders.DataSource = sliders; // GridView'in veri kaynağı bu listedir
            gvSliders.DataBind(); // Veriyi GridView'e bağla (ekranda göster)
        }

        // GridView'deki "Sil" butonuna tıklandığında çalışacak metot
        protected void gvSliders_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // 1. Tıklanan satırın ID'sini al
            // (DataKeyNames="SliderID" sayesinde ID'yi kolayca alabiliriz)
            int sliderId = Convert.ToInt32(gvSliders.DataKeys[e.RowIndex].Value);

            // 2. Business katmanına git ve "DeleteSlider" metodunu çalıştır
            sliderManager.DeleteSlider(sliderId);

            // 3. Silme işleminden sonra listeyi yenile
            BindSliderGrid();
        }
    }
}