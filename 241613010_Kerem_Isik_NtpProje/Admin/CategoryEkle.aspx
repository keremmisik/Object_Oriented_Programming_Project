<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="CategoryEkle.aspx.cs" Inherits="_241613010_Kerem_Isik_NtpProje.Admin.CategoryEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h2>Yeni Kategori Ekle</h2>
    <p>
        Lütfen yeni kategori adını girin.
    </p>

    <table style="width: 400px;">
        <tr>
            <td>Kategori Adı:</td>
            <td>
                <asp:TextBox ID="txtName" runat="server" Width="300px"></asp:TextBox></td>
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
