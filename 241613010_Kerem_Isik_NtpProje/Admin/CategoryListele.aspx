<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="CategoryListele.aspx.cs" Inherits="_241613010_Kerem_Isik_NtpProje.Admin.CategoryListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h2>Kategori Yönetimi</h2>
    <p>
        Mevcut çalışmaları kategorilerini yönetin.
    </p>

    <a href="CategoryEkle.aspx" class="btn-ekle-link">(+) Yeni Kategori Ekle</a>
    
    <br /><br />

    <asp:GridView 
        ID="gvCategories" 
        runat="server" 
        AutoGenerateColumns="False" 
        CellPadding="4"
        Width="500px"
        DataKeyNames="CategoryID" 
        OnRowDeleting="gvCategories_RowDeleting">
        
        <Columns>
            <asp:BoundField DataField="CategoryID" HeaderText="ID" />
            
            <asp:BoundField DataField="CategoryName" HeaderText="Kategori Adı" />
            
            <asp:TemplateField HeaderText="İşlemler">
                <ItemTemplate>
                    <a href='CategoryDuzenle.aspx?ID=<%# Eval("CategoryID") %>'>Düzenle</a>
                    
                    &nbsp;|&nbsp; 

                    <asp:LinkButton 
                        ID="btnDelete" 
                        runat="server" 
                        CommandName="Delete" 
                        OnClientClick="return confirm('Bu kaydı silmek istediğinizden emin misiniz?');">Sil</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
    </asp:GridView>

</asp:Content>
