using NtpProje_Business;
using NtpProje_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _241613010_Kerem_Isik_NtpProje.Admin
{
    public partial class ContactMesajlari : System.Web.UI.Page
    {
        ContactManager messageManager = new ContactManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindMessageGrid();
            }
        }

        private void BindMessageGrid()
        {
            // Tüm mesajları tarihe göre tersten sıralayarak (en yeni en üstte) getir
            var messages = messageManager.GetAllMessages().OrderByDescending(m => m.SubmissionDate).ToList();

            gvMessages.DataSource = messages;
            gvMessages.DataBind();
        }

        protected void gvMessages_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int messageId = Convert.ToInt32(gvMessages.DataKeys[e.RowIndex].Value);
            messageManager.DeleteMessage(messageId);
            BindMessageGrid();
            pnlDetail.Visible = false;
        }

        protected void gvMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            int messageId = Convert.ToInt32(gvMessages.SelectedDataKey.Value);
            contactmessage message = messageManager.GetMessageById(messageId);

            if (message != null)
            {
                // Detayları göster
                lblFullName.Text = message.FirstName;
                lblEmail.Text = message.Email;
                lblSubject.Text = message.Subject;
                lblDate.Text = message.SubmissionDate.ToString("dd.MM.yyyy HH:mm");
                lblMessage.Text = message.Message;
                pnlDetail.Visible = true;

                // Okundu olarak işaretle
                if (!message.IsRead)
                {
                    message.IsRead = true;
                    messageManager.MarkAsRead(messageId);

                    // Grid'i yenilemek için tekrar yükle
                    BindMessageGrid();
                }
            }
        }
    }
}