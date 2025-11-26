<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="NewsEkle.aspx.cs" Inherits="_241613010_Kerem_Isik_NtpProje.Admin.NewsEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h2>Yeni Haber Ekle</h2>
    <p>
        Haber detaylarını girin. Yayın tarihi otomatik atanacaktır.
    </p>

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
                <asp:TextBox ID="txtImagePath" runat="server" Width="500px" 
                    placeholder="Örn: img/blog/haber1.jpg"></asp:TextBox>
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
