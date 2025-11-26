<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AdminDefault.aspx.cs" Inherits="_241613010_Kerem_Isik_NtpProje.Admin.AdminDefault" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h2>Admin Dashboard</h2>
    <p>
        Sistem yönetimine hoş geldiniz. Yönetim menüsünü sol panelde bulabilirsiniz.
    </p>

    <div style="margin-top: 50px; padding: 20px; background-color: #f0f8ff; border: 1px solid #b0e0e6;">
        <h3>Proje Durumu:</h3>
        <ul>
            <li>**Mimari:** Katmanlı Mimari ve Repository Pattern ile Tamamlandı.</li>
            <li>**Veritabanı:** 9 Tablolu CodeFirst Veritabanı Oluşturuldu.</li>
            <li>**Yönetim:** 9 Modül İçin CRUD (Ekle/Sil/Düzenle) İşlemleri Tamamlandı.</li>
        </ul>
        <p>Lütfen soldaki menüden istediğiniz modülü seçerek içeriği yönetin.</p>
    </div>

</asp:Content>
