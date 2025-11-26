<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="SliderListele.aspx.cs" Inherits="_241613010_Kerem_Isik_NtpProje.Admin.SliderListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h2>Slider Yönetimi</h2>
    <p>
        Mevcut slaytları yönetin veya yeni bir slayt ekleyin.
    </p>

    <a href="SliderEkle.aspx" class="btn-ekle-link">(+) Yeni Slider Ekle</a>
    
    <br /><br />

    <asp:GridView 
        ID="gvSliders" 
        runat="server" 
        AutoGenerateColumns="False" 
        CellPadding="4"
        Width="100%"
        DataKeyNames="SliderID" 
        OnRowDeleting="gvSliders_RowDeleting">
        
        <Columns>
            <asp:BoundField DataField="SliderID" HeaderText="ID" />
            
            <asp:BoundField DataField="Title" HeaderText="Başlık" />
            
            <asp:TemplateField HeaderText="Aktif mi?">
                <ItemTemplate>
                    <%# (bool)Eval("IsActive") ? "Evet" : "Hayır" %>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:BoundField DataField="Order" HeaderText="Sıra" />

            <asp:TemplateField HeaderText="İşlemler">
                <ItemTemplate>
                    <a href='SliderDuzenle.aspx?ID=<%# Eval("SliderID") %>'>Düzenle</a>
                    
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
