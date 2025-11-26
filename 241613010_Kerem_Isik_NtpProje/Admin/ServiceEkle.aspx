<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ServiceEkle.aspx.cs" Inherits="_241613010_Kerem_Isik_NtpProje.Admin.ServiceEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h2>Yeni Hizmet Ekle</h2>

    <table style="width: 700px;">
        <tr>
            <td>Başlık:</td>
            <td>
                <asp:TextBox ID="txtTitle" runat="server" Width="500px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Alt Başlık:</td>
            <td>
                <asp:TextBox ID="txtSubtitle" runat="server" Width="500px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Açıklama:</td>
            <td>
                <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Rows="5" Width="500px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>İkon Kodu:</td>
            <td>
                <asp:TextBox ID="txtIconClass" runat="server" Width="200px" 
                    placeholder="Örn: icon-desktop"></asp:TextBox>
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
