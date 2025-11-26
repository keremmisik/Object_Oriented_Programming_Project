<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="PortfolioListele.aspx.cs" Inherits="_241613010_Kerem_Isik_NtpProje.Admin.PortfolioListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h2>Çalışmalar Yönetimi (Portfolio)</h2>
    <p>
        Mevcut çalışmaları yönetin.
    </p>

    <a href="PortfolioEkle.aspx" class="btn-ekle-link">(+) Yeni Çalışma Ekle</a>
    
    <br /><br />

    <asp:GridView 
        ID="gvPortfolios" 
        runat="server" 
        AutoGenerateColumns="False" 
        CellPadding="4"
        Width="100%"
        DataKeyNames="PortfolioID" 
        OnRowDeleting="gvPortfolios_RowDeleting">
        
        <Columns>
            <asp:BoundField DataField="PortfolioID" HeaderText="ID" />
            <asp:BoundField DataField="Title" HeaderText="Başlık" />
            
            <asp:TemplateField HeaderText="Kategori">
                <ItemTemplate>
                    <%# Eval("Category.CategoryName") %>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:BoundField DataField="Client" HeaderText="Müşteri" />
            
            <asp:TemplateField HeaderText="Aktif mi?">
                <ItemTemplate>
                    <%# (bool)Eval("IsActive") ? "Evet" : "Hayır" %>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:BoundField DataField="WorkDate" HeaderText="Tarih" DataFormatString="{0:dd.MM.yyyy}" />

            <asp:TemplateField HeaderText="İşlemler">
                <ItemTemplate>
                    <a href='PortfolioDuzenle.aspx?ID=<%# Eval("PortfolioID") %>'>Düzenle</a>
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
