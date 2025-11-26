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
    public partial class TeamMemberListele : System.Web.UI.Page
    {
        TeamMemberManager teamManager = new TeamMemberManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindTeamMemberGrid();
            }
        }

        private void BindTeamMemberGrid()
        {
            var members = teamManager.GetAllTeamMembers();
            gvTeamMembers.DataSource = members;
            gvTeamMembers.DataBind();
        }

        protected void gvTeamMembers_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int memberId = Convert.ToInt32(gvTeamMembers.DataKeys[e.RowIndex].Value);
            teamManager.DeleteTeamMember(memberId);
            BindTeamMemberGrid();
        }
    }
}