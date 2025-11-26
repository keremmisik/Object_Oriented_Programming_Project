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
    public partial class ServiceDuzenle : System.Web.UI.Page
    {
        ServiceManager serviceManager = new ServiceManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["ID"] != null)
                {
                    int serviceId = Convert.ToInt32(Request.QueryString["ID"]);
                    LoadServiceData(serviceId);
                }
                else
                {
                    Response.Redirect("ServiceListele.aspx");
                }
            }
        }

        private void LoadServiceData(int id)
        {
            service service = serviceManager.GetServiceById(id);

            if (service != null)
            {
                hdnServiceID.Value = service.ServiceID.ToString();
                txtTitle.Text = service.Title;
                txtSubtitle.Text = service.Subtitle;
                txtDescription.Text = service.Description;
                txtIconClass.Text = service.IconClass;
                txtOrder.Text = service.Order.ToString();
                chkIsActive.Checked = service.IsActive;
            }
            else
            {
                Response.Redirect("ServiceListele.aspx");
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int serviceId = Convert.ToInt32(hdnServiceID.Value);
                service serviceToUpdate = serviceManager.GetServiceById(serviceId);

                if (serviceToUpdate != null)
                {
                    serviceToUpdate.Title = txtTitle.Text;
                    serviceToUpdate.Subtitle = txtSubtitle.Text;
                    serviceToUpdate.Description = txtDescription.Text;
                    serviceToUpdate.IconClass = txtIconClass.Text;
                    serviceToUpdate.Order = Convert.ToInt32(txtOrder.Text);
                    serviceToUpdate.IsActive = chkIsActive.Checked;

                    serviceManager.UpdateService(serviceToUpdate);
                    Response.Redirect("ServiceListele.aspx");
                }
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