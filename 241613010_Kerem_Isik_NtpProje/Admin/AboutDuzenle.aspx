<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AboutDuzenle.aspx.cs" Inherits="_241613010_Kerem_Isik_NtpProje.Admin.AboutDuzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h2>Hakkımızda Sayfası İçerik Yönetimi</h2>
    <p>
        Bu sayfadaki bilgiler, web sitesinin "Hakkımızda" bölümünde yer alacaktır.
    </p>
    
    <asp:HiddenField ID="hdnAboutID" runat="server" Value="0" />

    <table style="width: 800px;">
        <tr>
            <td>Başlık:</td>
            <td>
                <asp:TextBox ID="txtTitle" runat="server" Width="600px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Kısa Tanıtım (Misyon):</td>
            <td>
                <asp:TextBox ID="txtSubtitle" runat="server" Width="600px" TextMode="MultiLine" Rows="3"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Tam İçerik (Vizyon/Hakkında):</td>
            <td>
                <asp:TextBox ID="txtContent" runat="server" TextMode="MultiLine" Rows="15" Width="600px"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnSave" runat="server" Text="Kaydet/Güncelle" OnClick="btnSave_Click" />
            </td>
        </tr>
    </table>

</asp:Content>
