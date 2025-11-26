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
    public partial class ServiceListele : System.Web.UI.Page
    {
        ServiceManager serviceManager = new ServiceManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindServiceGrid();
            }
        }

        private void BindServiceGrid()
        {
            var services = serviceManager.GetAllServices();

            gvServices.DataSource = services;
            gvServices.DataBind();
        }

        protected void gvServices_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int serviceId = Convert.ToInt32(gvServices.DataKeys[e.RowIndex].Value);
            serviceManager.DeleteService(serviceId);
            BindServiceGrid();
        }
    }
}