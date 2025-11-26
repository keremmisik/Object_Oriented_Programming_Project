<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ContactMesajlari.aspx.cs" Inherits="_241613010_Kerem_Isik_NtpProje.Admin.ContactMesajlari" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h2>Gelen İletişim Mesajları</h2>
    <p>
        Kullanıcılardan gelen tüm mesajlar aşağıda listelenmiştir.
    </p>

    <asp:GridView 
        ID="gvMessages" 
        runat="server" 
        AutoGenerateColumns="False" 
        CellPadding="4"
        Width="100%"
        DataKeyNames="MessageID" 
        OnRowDeleting="gvMessages_RowDeleting"
        OnSelectedIndexChanged="gvMessages_SelectedIndexChanged"
        AlternatingRowStyle-BackColor="#f5f5f5">
        
        <Columns>
            <asp:BoundField DataField="MessageID" HeaderText="ID" />
            <asp:BoundField DataField="FirstName" HeaderText="Gönderen" />
            <asp:BoundField DataField="Email" HeaderText="E-Posta" />
            <asp:BoundField DataField="Subject" HeaderText="Konu" />
            <asp:BoundField DataField="SubmissionDate" HeaderText="Tarih" DataFormatString="{0:dd.MM.yyyy HH:mm}" />

            <asp:TemplateField HeaderText="Okundu mu?">
                <ItemTemplate>
                    <asp:Label ID="lblIsRead" runat="server" 
                        Text='<%# (bool)Eval("IsRead") ? "Evet" : "Hayır" %>'
                        Font-Bold='<%# (bool)Eval("IsRead") ? false : true %>'
                        ForeColor='<%# (bool)Eval("IsRead") ? System.Drawing.Color.Black : System.Drawing.Color.Red %>'>
                    </asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:CommandField HeaderText="Oku" SelectText="Detay" ShowSelectButton="True" />
            
            <asp:TemplateField HeaderText="Sil">
                <ItemTemplate>
                    <asp:LinkButton 
                        ID="btnDelete" 
                        runat="server" 
                        CommandName="Delete" 
                        OnClientClick="return confirm('Bu mesajı silmek istediğinizden emin misiniz?');">Sil</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

    <br /><hr /><br />

    <asp:Panel ID="pnlDetail" runat="server" Visible="false">
        <h3>Mesaj Detayı</h3>
        <p><strong>Gönderen:</strong> <asp:Label ID="lblFullName" runat="server"></asp:Label></p>
        <p><strong>E-Posta:</strong> <asp:Label ID="lblEmail" runat="server"></asp:Label></p>
        <p><strong>Konu:</strong> <asp:Label ID="lblSubject" runat="server"></asp:Label></p>
        <p><strong>Mesaj Tarihi:</strong> <asp:Label ID="lblDate" runat="server"></asp:Label></p>
        <p><strong>Mesaj İçeriği:</strong> <br /><asp:Label ID="lblMessage" runat="server"></asp:Label></p>
    </asp:Panel>

</asp:Content>
