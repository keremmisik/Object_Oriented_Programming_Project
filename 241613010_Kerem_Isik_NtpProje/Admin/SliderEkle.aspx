<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="SliderEkle.aspx.cs" Inherits="_241613010_Kerem_Isik_NtpProje.Admin.SliderEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h2>Yeni Slider Ekle</h2>
    <p>
        Lütfen yeni slayt için tüm alanları doldurun.
    </p>

    <table style="width: 500px;">
        <tr>
            <td>Başlık:</td>
            <td>
                <asp:TextBox ID="txtTitle" runat="server" Width="300px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Resim Yolu:</td>
            <td>
                <asp:TextBox ID="txtImagePath" runat="server" Width="300px" 
                    placeholder="Örn: img/slider/slide1.jpg"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Madde 1:</td>
            <td>
                <asp:TextBox ID="txtLine1" runat="server" Width="300px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Madde 2:</td>
            <td>
                <asp:TextBox ID="txtLine2" runat="server" Width="300px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Madde 3:</td>
            <td>
                <asp:TextBox ID="txtLine3" runat="server" Width="300px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Sıra:</td>
            <td>
                <asp:TextBox ID="txtOrder" runat="server" Width="100px" Text="0" 
                    TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Aktif mi?</td>
            <td>
                <asp:CheckBox ID="chkIsActive" runat="server" Checked="true" />
                (İşaretliyse ana sayfada görünür)
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
