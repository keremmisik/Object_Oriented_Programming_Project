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
    public partial class SliderEkle : System.Web.UI.Page
    {
        // Business katmanındaki Manager'ımızı çağırıyoruz
        SliderManager sliderManager = new SliderManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            // Bu sayfada Page_Load'da bir işlem yapmamıza gerek yok.
        }

        // "Kaydet" butonuna tıklandığında çalışacak metot
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Entities katmanından yeni, boş bir Slider nesnesi oluştur.
                Slider newSlider = new Slider();

                // 2. Bu nesnenin içini formdaki (TextBox, CheckBox) verilerle doldur.
                newSlider.Title = txtTitle.Text;
                newSlider.ImagePath = txtImagePath.Text;
                newSlider.Line1 = txtLine1.Text;
                newSlider.Line2 = txtLine2.Text;
                newSlider.Line3 = txtLine3.Text;
                newSlider.Order = Convert.ToInt32(txtOrder.Text);
                newSlider.IsActive = chkIsActive.Checked;

                // 3. Business katmanına git ve "AddSlider" metodunu çalıştır.
                sliderManager.AddSlider(newSlider);

                // 4. Ekleme başarılıysa, kullanıcıyı tekrar LİSTE sayfasına yönlendir.
                Response.Redirect("SliderListele.aspx");
            }
            catch (Exception ex)
            {
                // Eğer bir hata olursa (örn: Sıra'ya sayı yerine harf girerse)
                // Şimdilik basitçe Label'a yazdırabiliriz.
                // (Daha sonra buraya güzel bir hata mesajı ekleriz)
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