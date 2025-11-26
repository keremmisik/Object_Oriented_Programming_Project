using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NtpProje_Business;

namespace _241613010_Kerem_Isik_NtpProje
{
    public partial class hizmetlerimiz : System.Web.UI.Page
    {
        ServiceManager serviceManager = new ServiceManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindServices();
            }
        }

        private void BindServices()
        {
            // İş Kuralı: Aktif olan ve Sıralı Hizmetleri getir.
            var services = serviceManager.GetActiveServicesOrdered();

            // Repeater'a bağla
            rptServices.DataSource = services;
            rptServices.DataBind();
        }
    }
}