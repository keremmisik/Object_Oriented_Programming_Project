<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="hakkimizda.aspx.cs" Inherits="_241613010_Kerem_Isik_NtpProje.hakkimizda" %>

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
                    <h1>Hakkımızda</h1>
                </div>

                <ul class="breadcrumbs">
                    <li><a class="home" href="#">Home</a></li>
                    <li>/</li>
                    <li><span class="active">Hakkımızda</span></li>
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



            <!-- .grid_6 start -->
            <article class="grid_6">
                <section class="section-title left">
                    <h3>
                        <asp:Literal ID="litTitle" runat="server"></asp:Literal></h3>
                </section>

                <span class="text-dark text-big">
                    <asp:Literal ID="litSubtitle" runat="server"></asp:Literal>
                </span>

                <br />
                <br />

                <asp:Image ID="imgAbout" runat="server" Width="100%" Visible="false" Style="margin-bottom: 15px;" />

                <p>
                    <asp:Literal ID="litContent" runat="server"></asp:Literal>
                </p>
            </article>
            <!-- .grid_6 end -->

            <div class="clearfix"></div>

            <!-- .grid_8 start -->


            <!-- grid_4 start -->

            <!-- .grid_12 start -->
            <article class="grid_12">
                <section class="section-title center">
                    <div class="title-container">
                        <section class="title">
                            <h2>Ekibimiz</h2>
                            <span>Profesyonel kadromuzla tanışın.</span>
                        </section>
                    </div>
                </section>

                <asp:Repeater ID="rptTeam" runat="server">
                    <ItemTemplate>
                        <article class="grid_3 team">
                            <section class="team-info">
                                <img src='<%# Eval("ImagePath") %>' alt="team member" />

                                <div class="title-position">
                                    <div class="title">
                                        <h6><%# Eval("FullName") %></h6>
                                    </div>
                                    <div class="position">
                                        <span><%# Eval("Position") %></span>
                                    </div>
                                </div>
                            </section>
                            <section class="team-cv">
                                <p>
                                    <%# Eval("Biography") %>
                                </p>
                            </section>
                        </article>
                    </ItemTemplate>
                </asp:Repeater>

            </article>
            <!-- .grid_12 end -->


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
        $(window).load(function () {
            $('#slider').nivoSlider();
        });

        /* CLIENTS SCROLL */
        $('#client-carousel').carouFredSel({
            prev: '.prev',
            next: '.next',
            auto: false,
            scroll: 1,
            width: 'variable',
            height: 'variable',
            swipe: {
                ontouch: true,
                onMouse: true
            },
            items: {
                width: 'auto',
                visible: 5
            }
        });

        // FOOTER CAROUSEL ARTICLE 
        $("#foo1").carouFredSel({
            auto: true,
            scroll: 1,
            pagination: "#foo1_pag",
            width: 'variable',
            height: 'variable',
            swipe: {
                ontouch: true,
                onMouse: true
            },
            items: {
                width: 'auto',
                visible: 1
            }
        });
        /* ]]> */
    </script>
</asp:Content>
