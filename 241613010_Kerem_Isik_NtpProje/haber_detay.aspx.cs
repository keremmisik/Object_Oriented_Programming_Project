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
    public partial class haber_detay : System.Web.UI.Page
    {
        NewsManager newsManager = new NewsManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // 1. URL'den ID'yi al
                if (Request.QueryString["ID"] != null)
                {
                    if (int.TryParse(Request.QueryString["ID"], out int newsId))
                    {
                        LoadNewsDetail(newsId);
                    }
                }
                else
                {
                    // ID yoksa ana sayfaya yönlendir
                    Response.Redirect("index.aspx");
                }
            }
        }

        private void LoadNewsDetail(int id)
        {
            // 2. Business katmanından haberi ID'ye göre getir
            news newsItem = newsManager.GetNewsById(id);

            if (newsItem != null && newsItem.IsActive) // Haber aktif mi diye kontrol et
            {
                // 3. Kontrollere veriyi bağla
                lblTitle.Text = newsItem.Title;
                lblPublishDate.Text = newsItem.PublishDate.ToString("dd MMMM yyyy");
                lblFullContent.Text = newsItem.FullContent;
                imgNews.ImageUrl = newsItem.ImagePath; // Resim yolunu bağla
            }
            else
            {
                // Haber bulunamazsa veya aktif değilse
                Response.Redirect("index.aspx");
            }
        }
    }
}