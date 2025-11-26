<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="PortfolioDuzenle.aspx.cs" Inherits="_241613010_Kerem_Isik_NtpProje.Admin.PortfolioDuzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h2>Çalışma Düzenle (Portfolio)</h2>
    <p>
        Çalışma bilgilerini güncelleyebilirsiniz.
    </p>

    <asp:HiddenField ID="hdnPortfolioID" runat="server" />

    <table style="width: 700px;">
        <tr>
            <td>Başlık:</td>
            <td>
                <asp:TextBox ID="txtTitle" runat="server" Width="500px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Kategori:</td>
            <td>
                <asp:DropDownList ID="ddlCategory" runat="server" Width="300px"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Kısa Açıklama:</td>
            <td>
                <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Rows="5" Width="500px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Müşteri:</td>
            <td>
                <asp:TextBox ID="txtClient" runat="server" Width="300px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Teknolojiler:</td>
            <td>
                <asp:TextBox ID="txtTechnologies" runat="server" Width="500px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Küçük Resim Yolu:</td>
            <td>
                <asp:TextBox ID="txtThumbnailPath" runat="server" Width="500px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Büyük Resim Yolu:</td>
            <td>
                <asp:TextBox ID="txtLargeImagePath" runat="server" Width="500px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Çalışma Tarihi:</td>
            <td>
                <asp:TextBox ID="txtWorkDate" runat="server" TextMode="Date" 
                    Width="150px"></asp:TextBox>
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
                <asp:Button ID="btnSave" runat="server" Text="Güncelle" OnClick="btnSave_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="İptal" OnClick="btnCancel_Click" CausesValidation="false" />
            </td>
        </tr>
    </table>

</asp:Content>
