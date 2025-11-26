<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="TeamMemberEkle.aspx.cs" Inherits="_241613010_Kerem_Isik_NtpProje.Admin.TeamMemberEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h2>Yeni Ekip Üyesi Ekle</h2>

    <table style="width: 700px;">
        <tr>
            <td>Adı Soyadı:</td>
            <td>
                <asp:TextBox ID="txtFullName" runat="server" Width="500px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Pozisyon:</td>
            <td>
                <asp:TextBox ID="txtPosition" runat="server" Width="500px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Biyografi:</td>
            <td>
                <asp:TextBox ID="txtBiography" runat="server" TextMode="MultiLine" Rows="5" Width="500px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Resim Yolu:</td>
            <td>
                <asp:TextBox ID="txtImagePath" runat="server" Width="500px" 
                    placeholder="Örn: img/about/team1.jpg"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Sıra:</td>
            <td>
                <asp:TextBox ID="txtOrder" runat="server" Width="100px" Text="0" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Aktif mi?</td>
            <td>
                <asp:CheckBox ID="chkIsActive" runat="server" Checked="true" />
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnSave" runat="server" Text="Kaydet" OnClick="btnSave_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="İptal" OnClick="btnCancel_Click" CausesValidation="false" />
            </td>
        </tr>
    </table>

</asp:Content>
