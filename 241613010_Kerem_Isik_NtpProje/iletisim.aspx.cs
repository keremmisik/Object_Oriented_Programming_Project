using NtpProje_Business;
using NtpProje_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _241613010_Kerem_Isik_NtpProje
{
    public partial class iletisim : System.Web.UI.Page
    {
        ContactManager contactManager = new ContactManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindContactInfo();
            }
        }

        private void BindContactInfo()
        {
            // İletişim bilgilerini veritabanından çek
            var info = contactManager.GetFirstContactInfo();
            if (info != null)
            {
                litPageDesc.Text = info.PageDescription;
                litAddress.Text = info.Address;
                litPhone.Text = info.Phone;
                litEmail.Text = info.Email;
            }
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                // Mesaj nesnesini oluştur
                contactmessage msg = new contactmessage();
                // msg.LastName alanı için formda ayrı yer yapmadıysak isimi bölebiliriz veya FullName kullanabiliriz
                // Entity'de FirstName/LastName varsa formda da ayırmak daha iyidir ama
                // Şimdilik FullName'i FirstName'e atayalım:
                msg.FirstName = txtName.Text;
                msg.LastName = "";

                msg.Email = txtEmail.Text;
                msg.Subject = txtSubject.Text;
                msg.Message = txtMessage.Text;

                // Veritabanına kaydet
                contactManager.AddMessage(msg);

                // Başarı mesajı göster ve formu temizle
                pnlSuccess.Visible = true;
                txtName.Text = "";
                txtEmail.Text = "";
                txtSubject.Text = "";
                txtMessage.Text = "";
            }
            catch (Exception)
            {
                // Hata yönetimi
            }
        }
    }
}