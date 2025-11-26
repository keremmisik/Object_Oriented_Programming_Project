<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Raporlar.aspx.cs" Inherits="_241613010_Kerem_Isik_NtpProje.Admin.Raporlar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <script type="text/javascript">
        google.charts.load('current', { 'packages': ['corechart'] });
        google.charts.setOnLoadCallback(drawChart);

        function drawChart() {
            // C# tarafından doldurulacak veri alanı (ChartData değişkeni)
            var data = google.visualization.arrayToDataTable([
                ['Kategori', 'Proje Sayısı'],
                <%= ChartData %> 
            ]);

            var options = {
                title: 'Kategorilere Göre Proje Dağılımı',
                is3D: true,
                pieHole: 0.4,
            };

            var chart = new google.visualization.PieChart(document.getElementById('piechart_3d'));
            chart.draw(data, options);
        }
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h2>Sistem Raporları</h2>
    <p>Aşağıda kategori bazlı proje dağılım raporunu (Stored Procedure Kullanılarak) görmektesiniz.</p>

    <div style="display:flex; justify-content:space-between; margin-top:30px;">
        
        <div style="width: 45%;">
            <h3>Veri Tablosu</h3>
            <asp:GridView ID="gvReport" runat="server" CellPadding="10" ForeColor="#333333" GridLines="None" Width="100%">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#2c3e50" Font-Bold="True" ForeColor="White" Height="40px" />
                <RowStyle BackColor="#EFF3FB" Height="30px" />
            </asp:GridView>
        </div>

        <div style="width: 50%;">
            <h3>Görsel Grafik</h3>
            <div id="piechart_3d" style="width: 100%; height: 400px; border:1px solid #ddd;"></div>
        </div>

    </div>

</asp:Content>
