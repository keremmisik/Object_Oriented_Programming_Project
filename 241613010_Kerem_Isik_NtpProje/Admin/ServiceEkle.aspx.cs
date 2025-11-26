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
    public partial class ServiceEkle : System.Web.UI.Page
    {
        ServiceManager serviceManager = new ServiceManager();

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                service newService = new service();

                newService.Title = txtTitle.Text;
                newService.Subtitle = txtSubtitle.Text;
                newService.Description = txtDescription.Text;
                newService.IconClass = txtIconClass.Text;
                newService.Order = Convert.ToInt32(txtOrder.Text);
                newService.IsActive = chkIsActive.Checked;

                serviceManager.AddService(newService);

                Response.Redirect("ServiceListele.aspx");
            }
            catch (Exception ex)
            {
                // Hata yönetimi
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("ServiceListele.aspx");
        }
    }
}