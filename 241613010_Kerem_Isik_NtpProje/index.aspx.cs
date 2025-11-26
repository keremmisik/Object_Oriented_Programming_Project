using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NtpProje_Business;

namespace _241613010_Kerem_Isik_NtpProje
{
    public partial class index : System.Web.UI.Page
    {
        // Manager sınıflarını çağırıyoruz
        SliderManager sliderManager = new SliderManager();
        PortfolioManager portfolioManager = new PortfolioManager();
        NewsManager newsManager = new NewsManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindSliders();
                BindPortfolioPreview();
                BindNewsPreview();
            }
        }

        private void BindSliders()
        {
            // İş Kuralı: Aktif olan ve Sıralı Slider'ları getir.
            var sliders = sliderManager.GetActiveSlidersOrdered();

            // Repeater'a bağla
            rptSlider.DataSource = sliders;
            rptSlider.DataBind();
        }

        // ... [BindSliders metodu buraya kadar doğru]

        private void BindPortfolioPreview()
        {
            // İş Kuralı: Kategori bilgisiyle birlikte, aktif olan son 8 (veya carousel'in gösterdiği kadar) çalışmayı getir.
            // PortfolioManager'daki GetActivePortfoliosWithCategory metodunu kullanıyoruz.
            var portfolioPreview = portfolioManager.GetActivePortfoliosWithCategory().Take(8).ToList();

            // Repeater'a bağla
            rptPortfolioPreview.DataSource = portfolioPreview;
            rptPortfolioPreview.DataBind();
        }

        private void BindNewsPreview()
        {
            // İş Kuralı: Aktif olan son 4 haberi getir.
            var newsPreview = newsManager.GetActiveNewsOrderedByDate().Take(4).ToList();

            // Repeater'a bağla
            rptNewsPreview.DataSource = newsPreview;
            rptNewsPreview.DataBind();
        }
    }
}