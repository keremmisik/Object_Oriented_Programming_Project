<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ContactInfoDuzenle.aspx.cs" Inherits="_241613010_Kerem_Isik_NtpProje.Admin.ContactInfoDuzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h2>İletişim Bilgileri Yönetimi</h2>
    <p>
        Bu sayfadaki bilgiler, web sitesinin footer ve iletişim bölümlerinde kullanılacaktır.
    </p>
    
    <asp:HiddenField ID="hdnContactID" runat="server" Value="0" />

    <table style="width: 600px;">
        <tr>
            <td>Adres Satırı 1:</td>
            <td>
                <asp:TextBox ID="txtAddressLine1" runat="server" Width="400px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Telefon 1:</td>
            <td>
                <asp:TextBox ID="txtPhone1" runat="server" Width="200px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>E-Posta Adresi:</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" Width="300px"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnSave" runat="server" Text="Kaydet/Güncelle" OnClick="btnSave_Click" />
            </td>
        </tr>
    </table>

</asp:Content>