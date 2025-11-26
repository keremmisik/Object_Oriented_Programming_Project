<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="calismalarimiz.aspx.cs" Inherits="_241613010_Kerem_Isik_NtpProje.calismalarimiz" %>

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
                    <h1>Çalışmalarımız</h1>
                </div>

                <ul class="breadcrumbs">
                    <li><a class="home" href="#">Home</a></li>
                    <li>/</li>
                    <li><span class="active">Çalışmalarımız</span></li>
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
            <section class="grid_12 quicksand-filter-container">
                <span>Kategoriler: </span>
                <!-- portfolio quicksand filter start -->
                <ul id="quicksand-filter">
                    <li class="active"><a class="all" href="#">Hepsi</a></li>

                    <asp:Repeater ID="rptCategories" runat="server">
                        <ItemTemplate>
                            <li>
                                <a class='<%# "cat-" + Eval("CategoryID") %>' href="#"><%# Eval("CategoryName") %></a>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
                <!-- portfolio quicksand filter end -->
            </section>
            <!-- .quicksand-filter-container end -->
        </div>
        <!-- .container_12 end -->

        <!-- .container_12 start -->
        <section class="container_12 clearfix">
            <ul id="filter-item">
                <asp:Repeater ID="rptPortfolios" runat="server">
                    <ItemTemplate>
                        <li data-id='<%# "id-" + Eval("PortfolioID") %>' class='<%# "grid_3 portfolio-style-2 cat-" + Eval("CategoryID") %>' data-alpha='<%# "cat-" + Eval("CategoryID") %>'>
                            <figure class="portfolio clearfix">
                                <div class="portfolio-image">
                                    <a href='calismalarimiz_detay.aspx?ID=<%# Eval("PortfolioID") %>'>
                                        <img src='<%# Eval("ThumbnailPath") %>' width="220" alt="portfolio" />
                                    </a>
                                    <div class="portfolio-hover">
                                        <div class="mask"></div>
                                        <ul>
                                            <li class="portfolio-zoom">
                                                <a href='<%# Eval("LargeImagePath") %>' data-gal="prettyPhoto[pp_gallery]">zoom</a>
                                            </li>
                                            <li class="portfolio-single">
                                                <a href='calismalarimiz_detay.aspx?ID=<%# Eval("PortfolioID") %>'>single</a>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                                <figcaption>
                                    <a class="title"><%# Eval("Title") %></a>
                                    <span class="subtitle"><%# Eval("Category.CategoryName") %></span>
                                </figcaption>
                            </figure>
                        </li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
            <!-- #filter-item end -->

            <ul class="grid_12 portfolio-pagination">
                <li class="pagination">
                    <a class="pagination-prev" href="#">&#60; Geri</a>

                    <div class="pager">
                        <ul>
                            <li class="active">
                                <a href="#">1</a>
                            </li>

                            <li>
                                <a href="#">2</a>
                            </li>

                            <li>
                                <a href="#">3</a>
                            </li>
                        </ul>
                    </div>

                    <a class="pagination-next" href="#">İleri &#62;</a>
                </li>
                <!-- .pagination end -->

            </ul>
            <!-- .portfolio-pagination end -->

        </section>
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
    <script src="js/portfolio.js"></script>
    <!-- portfolio custom options -->
    <script src="js/quicksand.js"></script>
    <!-- quicksand filter -->
    <script src="js/jquery.prettyPhoto.js"></script>
    <!-- prettyPhoto lightbox -->
    <script src="js/jquery.touchSwipe-1.2.5.js"></script>
    <!-- support for touch swipe on mobile devices -->
    <script src="style-switcher/styleSwitcher.js"></script>
    <!-- Style Switcher plugin -->
    <script src="js/include.js"></script>
    <!-- jQuery custom options -->

    <script>
        /* <![CDATA[ */
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
