using NtpProje_Business;
using NtpProje_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NtpProje_Business;
using NtpProje_Entities;

namespace _241613010_Kerem_Isik_NtpProje.Admin
{
    public partial class AboutDuzenle : System.Web.UI.Page
    {
        AboutManager aboutManager = new AboutManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadAboutData();
            }
        }

        private void LoadAboutData()
        {
            // Veritabanındaki TEK About kaydını getirmeye çalış
            about about = aboutManager.GetFirstAbout();

            if (about != null)
            {
                // Kayıt VARSA: Formu doldur ve ID'yi sakla (Düzenleme modu)
                hdnAboutID.Value = about.AboutID.ToString();
                txtTitle.Text = about.Title;
                txtSubtitle.Text = about.TeamSectionSubtitle;
                txtContent.Text = about.MainDescription;
            }
            // Kayıt yoksa (about == null), form boş kalır (Ekleme modu)
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int aboutId = Convert.ToInt32(hdnAboutID.Value);

                if (aboutId > 0)
                {
                    // VAR OLAN KAYIT: GÜNCELLEME (Update)
                    about aboutToUpdate = aboutManager.GetAboutById(aboutId);
                    if (aboutToUpdate != null)
                    {
                        aboutToUpdate.Title = txtTitle.Text;
                        aboutToUpdate.TeamSectionSubtitle = txtSubtitle.Text;
                        aboutToUpdate.MainDescription = txtContent.Text;

                        aboutManager.UpdateAbout(aboutToUpdate);
                        // Başarıyla güncellendi mesajı gösterilebilir (Şimdilik gerek yok)
                    }
                }
                else
                {
                    // YENİ KAYIT: EKLEME (Create)
                    about newAbout = new about
                    {
                        Title = txtTitle.Text,
                        TeamSectionSubtitle = txtSubtitle.Text,
                        MainDescription = txtContent.Text
                    };
                    aboutManager.AddAbout(newAbout);

                    // Yeni eklenen kaydı formda göstermek için sayfayı yenile
                    Response.Redirect(Request.RawUrl);
                }
            }
            catch (Exception ex)
            {
                // Hata yönetimi
            }
        }
    }
}