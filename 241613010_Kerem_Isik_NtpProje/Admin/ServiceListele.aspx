<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ServiceListele.aspx.cs" Inherits="_241613010_Kerem_Isik_NtpProje.Admin.ServiceListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h2>Hizmet Yönetimi</h2>
    <a href="ServiceEkle.aspx" class="btn-ekle-link">(+) Yeni Hizmet Ekle</a>
    
    <br /><br />

    <asp:GridView 
        ID="gvServices" 
        runat="server" 
        AutoGenerateColumns="False" 
        CellPadding="4"
        Width="100%"
        DataKeyNames="ServiceID" 
        OnRowDeleting="gvServices_RowDeleting">
        
        <Columns>
            <asp:BoundField DataField="ServiceID" HeaderText="ID" />
            <asp:BoundField DataField="Title" HeaderText="Başlık" />
            <asp:BoundField DataField="IconClass" HeaderText="İkon Kodu" />
            
            <asp:TemplateField HeaderText="Aktif mi?">
                <ItemTemplate>
                    <%# (bool)Eval("IsActive") ? "Evet" : "Hayır" %>
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:BoundField DataField="Order" HeaderText="Sıra" />

            <asp:TemplateField HeaderText="İşlemler">
                <ItemTemplate>
                    <a href='ServiceDuzenle.aspx?ID=<%# Eval("ServiceID") %>'>Düzenle</a>
                    &nbsp;|&nbsp; 
                    <asp:LinkButton 
                        ID="btnDelete" 
                        runat="server" 
                        CommandName="Delete" 
                        OnClientClick="return confirm('Bu hizmeti silmek istediğinizden emin misiniz?');">Sil</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>