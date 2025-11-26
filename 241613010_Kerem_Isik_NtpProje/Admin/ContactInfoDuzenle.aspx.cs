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
    public partial class ContactInfoDuzenle : System.Web.UI.Page
    {
        ContactManager contactManager = new ContactManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadContactData();
            }
        }

        private void LoadContactData()
        {
            // Veritabanındaki TEK ContactInfo kaydını getirmeye çalış
            contactinfo contact = contactManager.GetFirstContactInfo();

            if (contact != null)
            {
                // Kayıt VARSA: Formu doldur ve ID'yi sakla (Düzenleme modu)
                hdnContactID.Value = contact.ContactInfoID.ToString();
                txtAddressLine1.Text = contact.Address;
                txtPhone1.Text = contact.Phone;
                txtEmail.Text = contact.Email;
            }
            // Kayıt yoksa, form boş kalır (Ekleme modu)
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int contactId = Convert.ToInt32(hdnContactID.Value);

                if (contactId > 0)
                {
                    // VAR OLAN KAYIT: GÜNCELLEME (Update)
                    contactinfo contactToUpdate = contactManager.GetContactInfoById(contactId);
                    if (contactToUpdate != null)
                    {
                        contactToUpdate.Address = txtAddressLine1.Text;
                        contactToUpdate.Phone = txtPhone1.Text;
                        contactToUpdate.Email = txtEmail.Text;

                        contactManager.UpdateContactInfo(contactToUpdate);
                    }
                }
                else
                {
                    // YENİ KAYIT: EKLEME (Create)
                    contactinfo newContact = new contactinfo
                    {
                        Address = txtAddressLine1.Text,
                        Phone = txtPhone1.Text,
                        Email = txtEmail.Text,
                    };
                    contactManager.AddContactInfo(newContact);

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