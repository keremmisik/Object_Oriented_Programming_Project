using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NtpProje_Business;
using NtpProje_Entities;

namespace _241613010_Kerem_Isik_NtpProje
{
    public partial class hakkimizda : System.Web.UI.Page
    {
        // İki farklı manager'a ihtiyacımız var
        AboutManager aboutManager = new AboutManager();
        TeamMemberManager teamManager = new TeamMemberManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindAboutContent(); // Tekil içeriği yükle
                BindTeamMembers();  // Ekip listesini yükle
            }
        }

        private void BindAboutContent()
        {
            // Veritabanındaki tek "Hakkımızda" kaydını getir
            var aboutContent = aboutManager.GetFirstAbout();

            if (aboutContent != null)
            {
                litTitle.Text = aboutContent.Title;
                litSubtitle.Text = aboutContent.TeamSectionSubtitle;
                litContent.Text = aboutContent.MainDescription;
            }
        }

        private void BindTeamMembers()
        {
            // Aktif olan ve sıralanmış ekip üyelerini getir
            var members = teamManager.GetActiveTeamMembersOrdered();

            rptTeam.DataSource = members;
            rptTeam.DataBind();
        }
    }
}