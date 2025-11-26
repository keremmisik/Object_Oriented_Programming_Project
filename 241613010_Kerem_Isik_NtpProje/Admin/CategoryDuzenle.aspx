<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="CategoryDuzenle.aspx.cs" Inherits="_241613010_Kerem_Isik_NtpProje.Admin.CategoryDuzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h2>Kategori Düzenle</h2>
    <p>
        Kategori adını güncelleyebilirsiniz.
    </p>
    
    <asp:HiddenField ID="hdnCategoryID" runat="server" />

    <table style="width: 400px;">
        <tr>
            <td>Kategori Adı:</td>
            <td>
                <asp:TextBox ID="txtName" runat="server" Width="300px"></asp:TextBox></td>
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
