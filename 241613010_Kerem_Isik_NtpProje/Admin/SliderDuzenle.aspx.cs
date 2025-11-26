using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NtpProje_Business; // Business katmanımız
using NtpProje_Entities; // Entities katmanımız (Slider sınıfı için)

namespace _241613010_Kerem_Isik_NtpProje.Admin
{
    public partial class SliderDuzenle : System.Web.UI.Page
    {
        // Business katmanındaki Manager'ımızı çağırıyoruz
        SliderManager sliderManager = new SliderManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Sayfa ilk kez yükleniyorsa
            {
                // URL'den (?ID=...) gelen ID'yi al
                if (Request.QueryString["ID"] != null)
                {
                    int sliderId = Convert.ToInt32(Request.QueryString["ID"]);
                    LoadSliderData(sliderId); // Formu doldurma metodunu çağır
                }
                else
                {
                    // ID yoksa, listeye geri yolla (hatalı geliş)
                    Response.Redirect("SliderListele.aspx");
                }
            }
        }

        // Formu, veritabanından gelen bilgilerle dolduran metot
        private void LoadSliderData(int id)
        {
            // 1. Business katmanına git ve ID'ye göre slaytı bul
            Slider slider = sliderManager.GetSliderById(id);

            if (slider != null)
            {
                // 2. Formdaki kontrollere verileri ata
                hdnSliderID.Value = slider.SliderID.ToString(); // ID'yi gizli alanda sakla
                txtTitle.Text = slider.Title;
                txtImagePath.Text = slider.ImagePath;
                txtLine1.Text = slider.Line1;
                txtLine2.Text = slider.Line2;
                txtLine3.Text = slider.Line3;
                txtOrder.Text = slider.Order.ToString();
                chkIsActive.Checked = slider.IsActive;
            }
            else
            {
                // Slayt bulunamazsa listeye geri yolla
                Response.Redirect("SliderListele.aspx");
            }
        }

        // "Güncelle" (Kaydet) butonuna tıklandığında çalışacak metot
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Güncellenecek nesneyi ID'sine göre bul
                int sliderId = Convert.ToInt32(hdnSliderID.Value);
                Slider sliderToUpdate = sliderManager.GetSliderById(sliderId);

                // 2. Nesnenin içini formdaki YENİ verilerle güncelle
                sliderToUpdate.Title = txtTitle.Text;
                sliderToUpdate.ImagePath = txtImagePath.Text;
                sliderToUpdate.Line1 = txtLine1.Text;
                sliderToUpdate.Line2 = txtLine2.Text;
                sliderToUpdate.Line3 = txtLine3.Text;
                sliderToUpdate.Order = Convert.ToInt32(txtOrder.Text);
                sliderToUpdate.IsActive = chkIsActive.Checked;

                // 3. Business katmanına git ve "UpdateSlider" metodunu çalıştır.
                sliderManager.UpdateSlider(sliderToUpdate);

                // 4. Güncelleme başarılıysa, kullanıcıyı tekrar LİSTE sayfasına yönlendir.
                Response.Redirect("SliderListele.aspx");
            }
            catch (Exception ex)
            {
                // Hata olursa...
                // lblError.Text = "Hata oluştu: " + ex.Message;
            }
        }

        // "İptal" butonuna tıklandığında çalışacak metot
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            // Kullanıcıyı LİSTE sayfasına geri yönlendir.
            Response.Redirect("SliderListele.aspx");
        }
    }
}