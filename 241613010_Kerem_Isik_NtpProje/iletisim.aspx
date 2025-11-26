<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="iletisim.aspx.cs" Inherits="_241613010_Kerem_Isik_NtpProje.iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- .top-shadow -->
    <div class="top-shadow"></div>

    <!-- .page-title-container start -->
    <section class="page-title-container">

        <!-- .container_12 start -->
        <div class="container_12">

            <!-- .page-title start -->
            <div class="page-title grid_12">
                <div class="title">
                    <h1>Bize Ulaşın</h1>
                </div>

                <ul class="breadcrumbs">
                    <li><a class="home" href="#">Home</a></li>
                    <li>/</li>
                    <li><span class="active">Bize Ulaşın</span></li>
                </ul>
            </div>
            <!-- .page-title end -->
        </div>
        <!-- .container_12 end -->
    </section>
    <!-- .page-title-container end -->

    <!-- #content-wrapper start -->
    <section id="content-wrapper">
        <div class="container_12">

            <div class="grid_6">
                <section class="section-title left">
                    <h3>Bize Yazın</h3>
                </section>

                <asp:Panel ID="pnlSuccess" runat="server" Visible="false" CssClass="success-box" Style="background: #dff0d8; padding: 10px; border: 1px solid #d6e9c6; color: #3c763d; margin-bottom: 15px;">
                    Mesajınız başarıyla gönderildi. Teşekkürler!
               
                </asp:Panel>

                <div class="wpcf7">
                    <fieldset>
                        <label>İsim Soyisim:</label>
                        <asp:TextBox ID="txtName" runat="server" CssClass="wpcf7-text"></asp:TextBox>
                    </fieldset>
                    <br />

                    <fieldset>
                        <label>E-posta:</label>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="wpcf7-text" TextMode="Email"></asp:TextBox>
                    </fieldset>
                    <br />

                    <fieldset>
                        <label>Konu:</label>
                        <asp:TextBox ID="txtSubject" runat="server" CssClass="wpcf7-text"></asp:TextBox>
                    </fieldset>
                    <br />

                    <fieldset>
                        <label>Mesajınız:</label>
                        <asp:TextBox ID="txtMessage" runat="server" CssClass="wpcf7-textarea" TextMode="MultiLine" Rows="7"></asp:TextBox>
                    </fieldset>
                    <br />

                    <asp:Button ID="btnSend" runat="server" Text="Gönder" CssClass="wpcf7-submit" OnClick="btnSend_Click" />
                </div>
            </div>

            <div class="grid_6">
                <section class="section-title left">
                    <h3>İletişim Bilgileri</h3>
                </section>

                <p>
                    <asp:Literal ID="litPageDesc" runat="server"></asp:Literal>
                </p>

                <ul class="contact-info">
                    <li>
                        <span class="text-dark">Adres:</span>
                        <asp:Literal ID="litAddress" runat="server"></asp:Literal>
                    </li>
                    <li>
                        <span class="text-dark">Telefon:</span>
                        <asp:Literal ID="litPhone" runat="server"></asp:Literal>
                    </li>
                    <li>
                        <span class="text-dark">E-posta:</span>
                        <asp:Literal ID="litEmail" runat="server"></asp:Literal>
                    </li>
                </ul>
            </div>

        </div>
    </section>

    <!-- scripts -->
    <script src="js/jquery-1.8.3.js"></script>
    <!-- jQuery library -->
    <script src="js/jquery.placeholder.min.js"></script>
    <!-- jQuery placeholder fix for old browsers -->
    <script src="http://maps.google.com/maps/api/js?sensor=true"></script>
    <!-- google maps -->
    <script src="js/jquery.ui.map.full.min.js"></script>
    <!-- jquery plugin for google maps -->
    <script src="js/jquery.carouFredSel-6.0.0-packed.js"></script>
    <!-- CarouFredSel carousel plugin -->
    <script src="js/jquery.touchSwipe-1.2.5.js"></script>
    <!-- support for touch swipe on mobile devices -->
    <script src="style-switcher/styleSwitcher.js"></script>
    <!-- Style Switcher plugin -->
    <script src="js/include.js"></script>
    <!-- jQuery custom options -->

    <script>
        /* <![CDATA[ */
        /* GOOGLE MAP */
        $(function () {
            //google maps

            var yourStartLatLng = new google.maps.LatLng(48.880833, 2.42333);
            $('.map_canvas').gmap({
                'center': yourStartLatLng, 'zoom': 15, 'disableDefaultUI': true, 'callback': function () {
                    var self = this;
                    self.addMarker({ 'position': this.get('map').getCenter() });
                }
            });
        });

        // FOOTER CAROUSEL ARTICLE 
        $("#foo1").carouFredSel({
            auto: true,
            scroll: 1,
            pagination: "#foo1_pag",
            swipe: {
                ontouch: true,
                onMouse: true
            },
            width: 'variable',
            height: 'variable',
            items: {
                width: 'auto',
                visible: 1
            }
        });
        /* ]]> */
    </script>
</asp:Content>
