<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="TeamMemberListele.aspx.cs" Inherits="_241613010_Kerem_Isik_NtpProje.Admin.TeamMemberListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h2>Ekip Üyeleri Yönetimi</h2>
    <a href="TeamMemberEkle.aspx" class="btn-ekle-link">(+) Yeni Ekip Üyesi Ekle</a>
    
    <br /><br />

    <asp:GridView 
        ID="gvTeamMembers" 
        runat="server" 
        AutoGenerateColumns="False" 
        CellPadding="4"
        Width="100%"
        DataKeyNames="TeamMemberID" 
        OnRowDeleting="gvTeamMembers_RowDeleting">
        
        <Columns>
            <asp:BoundField DataField="TeamMemberID" HeaderText="ID" />
            <asp:BoundField DataField="FullName" HeaderText="Adı Soyadı" />
            <asp:BoundField DataField="Position" HeaderText="Pozisyon" />
            
            <asp:TemplateField HeaderText="Aktif mi?">
                <ItemTemplate>
                    <%# (bool)Eval("IsActive") ? "Evet" : "Hayır" %>
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:BoundField DataField="Order" HeaderText="Sıra" />

            <asp:TemplateField HeaderText="İşlemler">
                <ItemTemplate>
                    <a href='TeamMemberDuzenle.aspx?ID=<%# Eval("TeamMemberID") %>'>Düzenle</a>
                    &nbsp;|&nbsp; 
                    <asp:LinkButton 
                        ID="btnDelete" 
                        runat="server" 
                        CommandName="Delete" 
                        OnClientClick="return confirm('Bu üyeyi silmek istediğinizden emin misiniz?');">Sil</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>
