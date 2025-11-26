using NtpProje_Business; // Business katmanımız
using NtpProje_Entities; // Entities katmanımız
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _241613010_Kerem_Isik_NtpProje.Admin
{
    public partial class TeamMemberEkle : System.Web.UI.Page
    {
        TeamMemberManager teamManager = new TeamMemberManager();

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                teammembers newMember = new teammembers();

                newMember.FullName = txtFullName.Text;
                newMember.Position = txtPosition.Text;
                newMember.Biography = txtBiography.Text;
                newMember.ImagePath = txtImagePath.Text;
                newMember.Order = Convert.ToInt32(txtOrder.Text);
                newMember.IsActive = chkIsActive.Checked;

                teamManager.AddTeamMember(newMember);

                Response.Redirect("TeamMemberListele.aspx");
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