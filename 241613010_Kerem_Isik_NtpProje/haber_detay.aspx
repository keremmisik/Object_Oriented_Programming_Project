<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="haber_detay.aspx.cs" Inherits="_241613010_Kerem_Isik_NtpProje.haber_detay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .news-detail-wrapper {
            background: #f8f9fa;
            padding: 40px 0;
        }
        
        .news-detail-container {
            max-width: 900px;
            margin: 0 auto;
            background: #fff;
            padding: 40px;
            border-radius: 8px;
            box-shadow: 0 2px 10px rgba(0,0,0,0.1);
        }
        
        .news-header {
            margin-bottom: 30px;
            border-bottom: 2px solid #f0f0f0;
            padding-bottom: 20px;
        }
        
        .news-title {
            font-size: 2.2em;
            color: #333;
            margin-bottom: 15px;
            line-height: 1.4;
            font-weight: 600;
        }
        
        .news-meta {
            color: #888;
            font-size: 0.95em;
            display: flex;
            align-items: center;
            gap: 15px;
        }
        
        .news-meta i {
            color: #007bff;
        }
        
        .news-image-container {
            margin-bottom: 35px;
            border-radius: 8px;
            overflow: hidden;
            box-shadow: 0 4px 15px rgba(0,0,0,0.1);
        }
        
        .news-image-container img {
            width: 100%;
            height: auto;
            display: block;
        }
        
        .news-content {
            font-size: 1.1em;
            line-height: 1.9;
            color: #444;
            text-align: justify;
        }
        
        .news-content p {
            margin-bottom: 20px;
        }
        
        .breadcrumbs {
            list-style: none;
            padding: 0;
            margin: 20px 0;
            display: flex;
            align-items: center;
            gap: 8px;
            font-size: 0.9em;
        }
        
        .breadcrumbs li {
            display: inline;
            color: #666;
        }
        
        .breadcrumbs a {
            color: #007bff;
            text-decoration: none;
            transition: color 0.3s;
        }
        
        .breadcrumbs a:hover {
            color: #0056b3;
        }
        
        .breadcrumbs .active {
            color: #333;
            font-weight: 500;
        }
        
        @media (max-width: 768px) {
            .news-detail-container {
                padding: 20px;
                margin: 0 15px;
            }
            
            .news-title {
                font-size: 1.6em;
            }
            
            .news-content {
                font-size: 1em;
            }
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="page-title-container">
        <div class="container_12">
            <ul class="breadcrumbs">
                <li><a href="index.aspx">🏠 Anasayfa</a></li>
                <li>/</li>
                <li><span class="active">Haber Detayı</span></li>
            </ul>
        </div>
    </div>
    
    <section class="news-detail-wrapper">
        <div class="news-detail-container">
            
            <div class="news-header">
                <h1 class="news-title">
                    <asp:Label ID="lblTitle" runat="server"></asp:Label>
                </h1>
                
                <div class="news-meta">
                    <span>📅 Yayın Tarihi: <asp:Label ID="lblPublishDate" runat="server"></asp:Label></span>
                </div>
            </div>

            <div class="news-image-container">
                <asp:Image ID="imgNews" runat="server" AlternateText="Haber Görseli" />
            </div>

            <div class="news-content">
                <asp:Label ID="lblFullContent" runat="server"></asp:Label>
            </div>
            
        </div>
    </section>

</asp:Content>