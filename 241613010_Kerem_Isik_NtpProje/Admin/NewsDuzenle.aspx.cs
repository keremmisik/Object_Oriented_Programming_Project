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
    public partial class NewsDuzenle : System.Web.UI.Page
    {
        NewsManager newsManager = new NewsManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["ID"] != null)
                {
                    int newsId = Convert.ToInt32(Request.QueryString["ID"]);
                    LoadNewsData(newsId);
                }
                else
                {
                    Response.Redirect("NewsListele.aspx");
                }
            }
        }

        private void LoadNewsData(int id)
        {
            news news = newsManager.GetNewsById(id);

            if (news != null)
            {
                hdnNewsID.Value = news.NewsID.ToString();
                txtTitle.Text = news.Title;
                txtSummary.Text = news.Summary;
                txtFullContent.Text = news.FullContent;
                txtImagePath.Text = news.ImagePath;
                chkIsActive.Checked = news.IsActive;

                // Tarihi HTML uyumlu formata (yyyy-MM-dd) dönüştür
                txtPublishDate.Text = news.PublishDate.ToString("yyyy-MM-dd");
            }
            else
            {
                Response.Redirect("NewsListele.aspx");
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int newsId = Convert.ToInt32(hdnNewsID.Value);
                news newsToUpdate = newsManager.GetNewsById(newsId);

                if (newsToUpdate != null)
                {
                    newsToUpdate.Title = txtTitle.Text;
                    newsToUpdate.Summary = txtSummary.Text;
                    newsToUpdate.FullContent = txtFullContent.Text;
                    newsToUpdate.ImagePath = txtImagePath.Text;
                    newsToUpdate.IsActive = chkIsActive.Checked;

                    // Tarihi güncelle (eğer değiştirilmişse)
                    if (DateTime.TryParse(txtPublishDate.Text, out DateTime publishDate))
                    {
                        newsToUpdate.PublishDate = publishDate;
                    }

                    newsManager.UpdateNews(newsToUpdate);
                    Response.Redirect("NewsListele.aspx");
                }
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