<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="calismalarimiz_detay.aspx.cs" Inherits="_241613010_Kerem_Isik_NtpProje.calismalarimiz_detay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- .top-shadow -->
    <div class="top-shadow"></div>

    <!-- .page-title-container start -->
    <section class="page-title-container">
        <div class="page-title grid_12">
            <div class="title">
                <h1>
                    <asp:Literal ID="litMainTitle" runat="server"></asp:Literal></h1>
            </div>
            <ul class="breadcrumbs">
                <li><a class="home" href="index.aspx">Home</a></li>
                <li>/</li>
                <li><span class="active">Çalışma Detayı</span></li>
            </ul>
        </div>
    </section>
    <!-- .page-title-container end -->

    <!-- #content-wrapper start -->
    <section id="content-wrapper">
        <section class="container_12 clearfix">

            <article class="grid_7 slider-wrapper">
                <div class="portfolio-single-image">
                    <asp:Image ID="imgBig" runat="server" Width="100%" />
                </div>
            </article>

            <article class="grid_5 portfolio-description">
                <h3>
                    <asp:Literal ID="litSubTitle" runat="server"></asp:Literal></h3>

                <ul class="meta">
                    <li>
                        <span>Kategori: </span>
                        <asp:Literal ID="litCategory" runat="server"></asp:Literal>
                    </li>
                    <li class="date">
                        <asp:Literal ID="litDate" runat="server"></asp:Literal></li>
                </ul>

                <p>
                    <asp:Literal ID="litDescription" runat="server"></asp:Literal>
                </p>

                <br />

                <ul>
                    <li><span class="text-dark">Müşteri: </span>
                        <asp:Literal ID="litClient" runat="server"></asp:Literal></li>
                    <li><span class="text-dark">Teknolojiler: </span>
                        <asp:Literal ID="litTech" runat="server"></asp:Literal></li>
                </ul>
            </article>

        </section>
    </section>
    <!-- #content-wrapper end -->
    <!-- scripts -->
    <script src="js/jquery-1.8.3.js"></script>
    <!-- jQuery library -->
    <script src="js/jquery.placeholder.min.js"></script>
    <!-- jQuery placeholder fix for old browsers -->
    <script src="js/jquery.carouFredSel-6.0.0-packed.js"></script>
    <!-- CarouFredSel carousel plugin -->
    <script src="js/portfolio.js"></script>
    <!-- portfolio custom options -->
    <script src="js/jquery.prettyPhoto.js"></script>
    <!-- prettyPhoto lightbox -->
    <script src="js/jquery.nivo.slider.js"></script>
    <!-- nivo slider -->
    <script src="js/jquery.touchSwipe-1.2.5.js"></script>
    <!-- support for touch swipe on mobile devices -->
    <script src="style-switcher/styleSwitcher.js"></script>
    <!-- Style Switcher plugin -->
    <script src="js/include.js"></script>
    <!-- jQuery custom options -->

    <script>
        /* <![CDATA[ */
        /* NIVO SLIDER */
        $(window).load(function () {
            $('#slider').nivoSlider();
        });

        // PORTFOLIO CAROUSEL
        $("#foo2").carouFredSel({
            auto: false,
            scroll: 1,
            pagination: "#foo2_pag",
            swipe: {
                ontouch: true,
                onMouse: true
            },
            width: 'variable',
            height: 'variable',
            items: {
                width: 'auto',
                visible: 4
            }
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
