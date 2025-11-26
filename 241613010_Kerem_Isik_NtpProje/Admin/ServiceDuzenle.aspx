<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ServiceDuzenle.aspx.cs" Inherits="_241613010_Kerem_Isik_NtpProje.Admin.ServiceDuzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h2>Hizmet Düzenle</h2>
    
    <asp:HiddenField ID="hdnServiceID" runat="server" />

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
                <asp:TextBox ID="txtIconClass" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Sıra:</td>
            <td>
                <asp:TextBox ID="txtOrder" runat="server" Width="100px" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Aktif mi?</td>
            <td>
                <asp:CheckBox ID="chkIsActive" runat="server" />
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnSave" runat="server" Text="Güncelle" OnClick="btnSave_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="İptal" OnClick="btnCancel_Click" CausesValidation="false" />
            </td>
        </tr>
    </table>

</asp:Content>
