<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="NewsDuzenle.aspx.cs" Inherits="_241613010_Kerem_Isik_NtpProje.Admin.NewsDuzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h2>Haber Düzenle</h2>
    <p>
        Haber detaylarını güncelleyin.
    </p>
    
    <asp:HiddenField ID="hdnNewsID" runat="server" />

    <table style="width: 700px;">
        <tr>
            <td>Başlık:</td>
            <td>
                <asp:TextBox ID="txtTitle" runat="server" Width="500px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Kısa Özet:</td>
            <td>
                <asp:TextBox ID="txtSummary" runat="server" TextMode="MultiLine" Rows="3" Width="500px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>İçerik:</td>
            <td>
                <asp:TextBox ID="txtFullContent" runat="server" TextMode="MultiLine" Rows="10" Width="500px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Resim Yolu:</td>
            <td>
                <asp:TextBox ID="txtImagePath" runat="server" Width="500px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Yayın Tarihi:</td>
            <td>
                <asp:TextBox ID="txtPublishDate" runat="server" TextMode="Date" Width="150px"></asp:TextBox>
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
