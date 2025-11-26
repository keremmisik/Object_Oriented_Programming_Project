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
    public partial class NewsEkle : System.Web.UI.Page
    {
        NewsManager newsManager = new NewsManager();

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                news newNews = new news();

                newNews.Title = txtTitle.Text;
                newNews.Summary = txtSummary.Text;
                newNews.FullContent = txtFullContent.Text;
                newNews.ImagePath = txtImagePath.Text;
                newNews.IsActive = chkIsActive.Checked;

                // Business katmanına git ve kaydet (PublishDate Manager'da otomatik atanır)
                newsManager.AddNews(newNews);

                // Ekleme başarılıysa, listeleme sayfasına yönlendir.
                Response.Redirect("NewsListele.aspx");
            }
            catch (Exception ex)
            {
                // Hata yönetimi
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewsListele.aspx");
        }
    }
}