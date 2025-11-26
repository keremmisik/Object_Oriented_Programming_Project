<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="hizmetlerimiz.aspx.cs" Inherits="_241613010_Kerem_Isik_NtpProje.hizmetlerimiz" %>

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
                    <h1>Hizmetlerimiz</h1>
                </div>

                <ul class="breadcrumbs">
                    <li><a class="home" href="#">Home</a></li>
                    <li>/</li>
                    <li><span class="active">Hizmetlerimiz</span></li>
                </ul>
            </div>
            <!-- .page-title end -->
        </div>
        <!-- .container_12 end -->
    </section>
    <!-- .page-title-container end -->

    <!-- #content-wrapper start -->
    <section id="content-wrapper">

        <!-- .container_12 start -->
        <div class="container_12">

            <asp:Repeater ID="rptServices" runat="server">
                <ItemTemplate>
                    <article class="grid_4">
                        <section class="service-box-1">
                            <div class="icon">
                                <i class='<%# Eval("IconClass") %>'></i>
                            </div>

                            <div class="content">
                                <div class="title">
                                    <h3><%# Eval("Title") %></h3>
                                    <span><%# Eval("Subtitle") %></span>
                                </div>

                                <div class="description">
                                    <p>
                                        <%# Eval("Description") %>
                                    </p>
                                </div>
                            </div>
                        </section>
                    </article>
                </ItemTemplate>
            </asp:Repeater>
            <div class="clearfix"></div>

        </div>
        <!-- .container_12 end -->
    </section>
    <!-- #content-wrapper end -->
    <!-- scripts -->
    <script src="js/jquery-1.8.3.js"></script>
    <!-- jQuery library -->
    <script src="js/jquery.placeholder.min.js"></script>
    <!-- jQuery placeholder fix for old browsers -->
    <script src="js/jquery.carouFredSel-6.0.0-packed.js"></script>
    <!-- CarouFredSel carousel plugin -->
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

        // NIVO SLIDER 
        $(window).load(function () {
            $('#slider').nivoSlider();
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
