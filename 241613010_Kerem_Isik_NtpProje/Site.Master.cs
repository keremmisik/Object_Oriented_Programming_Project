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
    public partial class Site : System.Web.UI.MasterPage
    {
        // ContactManager'ı çağırıyoruz
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
            // Veritabanındaki tek iletişim kaydını çek
            var contactInfo = contactManager.GetFirstContactInfo();

            if (contactInfo != null)
            {
                // Header (Üst Kısım) Bilgileri
                litPhoneHeader.Text = contactInfo.Phone;
                litEmailHeader.Text = contactInfo.Email;

                // Footer (Alt Kısım) Bilgileri
                litAddressFooter.Text = contactInfo.Address;
                litPhoneFooter.Text = contactInfo.Phone;
                litEmailFooter.Text = contactInfo.Email;
            }
        }
    }
}