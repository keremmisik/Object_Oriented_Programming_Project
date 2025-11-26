<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="NewsListele.aspx.cs" Inherits="_241613010_Kerem_Isik_NtpProje.Admin.NewsListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h2>Haber Yönetimi</h2>
    <a href="NewsEkle.aspx" class="btn-ekle-link">(+) Yeni Haber Ekle</a>
    
    <br /><br />

    <asp:GridView 
        ID="gvNews" 
        runat="server" 
        AutoGenerateColumns="False" 
        CellPadding="4"
        Width="100%"
        DataKeyNames="NewsID" 
        OnRowDeleting="gvNews_RowDeleting">
        
        <Columns>
            <asp:BoundField DataField="NewsID" HeaderText="ID" />
            <asp:BoundField DataField="Title" HeaderText="Başlık" />
            <asp:BoundField DataField="PublishDate" HeaderText="Yayın Tarihi" DataFormatString="{0:dd.MM.yyyy}" />

            <asp:TemplateField HeaderText="Aktif mi?">
                <ItemTemplate>
                    <%# (bool)Eval("IsActive") ? "Evet" : "Hayır" %>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="İşlemler">
                <ItemTemplate>
                    <a href='NewsDuzenle.aspx?ID=<%# Eval("NewsID") %>'>Düzenle</a>
                    &nbsp;|&nbsp; 
                    <asp:LinkButton 
                        ID="btnDelete" 
                        runat="server" 
                        CommandName="Delete" 
                        OnClientClick="return confirm('Bu haberi silmek istediğinizden emin misiniz?');">Sil</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>