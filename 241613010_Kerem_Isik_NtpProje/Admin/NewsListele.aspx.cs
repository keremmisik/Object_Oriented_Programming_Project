using NtpProje_Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NtpProje_Entities; // Entities katmanımız
using NtpProje_Business; // Business katmanımız

namespace _241613010_Kerem_Isik_NtpProje.Admin
{
    public partial class NewsListele : System.Web.UI.Page
    {
        NewsManager newsManager = new NewsManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindNewsGrid();
            }
        }

        private void BindNewsGrid()
        {
            // Tüm haberleri (aktif/pasif) getir
            var news = newsManager.GetAllNews();

            gvNews.DataSource = news;
            gvNews.DataBind();
        }

        protected void gvNews_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int newsId = Convert.ToInt32(gvNews.DataKeys[e.RowIndex].Value);

            // Business katmanına git ve sil
            newsManager.DeleteNews(newsId);

            // Silme işleminden sonra listeyi yenile
            BindNewsGrid();
        }
    }
}