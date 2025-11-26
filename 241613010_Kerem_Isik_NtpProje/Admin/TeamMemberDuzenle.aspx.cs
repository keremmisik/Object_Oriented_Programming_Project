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
    public partial class TeamMemberDuzenle : System.Web.UI.Page
    {
        TeamMemberManager teamManager = new TeamMemberManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["ID"] != null)
                {
                    int memberId = Convert.ToInt32(Request.QueryString["ID"]);
                    LoadMemberData(memberId);
                }
                else
                {
                    Response.Redirect("TeamMemberListele.aspx");
                }
            }
        }

        private void LoadMemberData(int id)
        {
            teammembers member = teamManager.GetTeamMemberById(id);

            if (member != null)
            {
                hdnMemberID.Value = member.TeamMemberID.ToString();
                txtFullName.Text = member.FullName;
                txtPosition.Text = member.Position;
                txtBiography.Text = member.Biography;
                txtImagePath.Text = member.ImagePath;
                txtOrder.Text = member.Order.ToString();
                chkIsActive.Checked = member.IsActive;
            }
            else
            {
                Response.Redirect("TeamMemberListele.aspx");
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int memberId = Convert.ToInt32(hdnMemberID.Value);
                teammembers memberToUpdate = teamManager.GetTeamMemberById(memberId);

                if (memberToUpdate != null)
                {
                    memberToUpdate.FullName = txtFullName.Text;
                    memberToUpdate.Position = txtPosition.Text;
                    memberToUpdate.Biography = txtBiography.Text;
                    memberToUpdate.ImagePath = txtImagePath.Text;
                    memberToUpdate.Order = Convert.ToInt32(txtOrder.Text);
                    memberToUpdate.IsActive = chkIsActive.Checked;

                    teamManager.UpdateTeamMember(memberToUpdate);
                    Response.Redirect("TeamMemberListele.aspx");
                }
            }
            catch (Exception ex)
            {
                // Hata yönetimi
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("TeamMemberListele.aspx");
        }
    }
}