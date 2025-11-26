using NtpProje_Business;
using NtpProje_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NtpProje_Api.Controllers
{
    public class SliderApiController : ApiController
    {
        // Business katmanındaki Manager'ı çağırıyoruz
        SliderManager sliderManager = new SliderManager();

        // Adres: /api/SliderApi
        // GET metodu: Tarayıcıdan çağrıldığında çalışır
        public List<Slider> Get()
        {
            // Aktif sliderları JSON/XML olarak döndürür
            return sliderManager.GetActiveSlidersOrdered();
        }

        // Belirli bir ID'ye göre getirmek için
        // Adres: /api/SliderApi/5
        public Slider Get(int id)
        {
            return sliderManager.GetSliderById(id);
        }
    }
}
