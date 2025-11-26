using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NtpProje_Entities;              // Slider, News vb. sınıflarımız için
using NtpProje_DataAccess.Concrete; // GenericRepository sınıfımız için
using NtpProje_DataAccess;          // NtpProjeContext sınıfımız için

namespace NtpProje_Business
{
    public class SliderManager
    {
        // --- Repository Desenini Kullanarak Veri Erişimi ---
        // Artık "new NtpProjeContext()" demiyoruz.
        // Repository sınıfımızı çağırıyoruz.

        // _sliderRepository adında, Slider tipi için çalışan 
        // bir GenericRepository oluşturuyoruz.
        private readonly GenericRepository<Slider> _sliderRepository;
        private readonly NtpProjeContext _context;

        public SliderManager()
        {
            // Manager sınıfı her "new" yapıldığında,
            // veritabanı (Context) ve Repository de (Depo) hazır olsun.
            _context = new NtpProjeContext();
            _sliderRepository = new GenericRepository<Slider>(_context);
        }

        // --- ANA SAYFA (index.aspx) İÇİN GEREKLİ METOT ---

        /// <summary>
        /// Ana sayfada gösterilmek üzere AKTİF olan ve
        /// Order (Sıra) alanına göre sıralanmış Slider listesini getirir.
        /// </summary>
        public List<Slider> GetActiveSlidersOrdered()
        {
            // Bu bizim "İş Kuralımız":
            // 1. Sadece IsActive alanı true olanları al.

            // Repository'mizin gelişmiş filtresini kullanıyoruz:
            var sliderList = _sliderRepository.GetList(s => s.IsActive == true);

            // 2. Bunları Order alanına göre küçükten büyüğe sırala.
            // (Bu sıralama işi bir "İş Kuralı" olduğu için Business'ta yapılır)
            return sliderList.OrderBy(s => s.Order).ToList();
        }

        // --- ADMİN PANELİ İÇİN GEREKLİ METOTLAR ---
        // Bu metotlar çoğunlukla Repository'deki metotları 
        // doğrudan çağırmaktan ibarettir.

        /// <summary>
        /// Admin panelinde tüm slider'ları (aktif/pasif) listelemek için.
        /// </summary>
        public List<Slider> GetAllSliders()
        {
            return _sliderRepository.GetAll();
        }

        /// <summary>
        /// ID'ye göre tek bir slider getirir.
        /// </summary>
        public Slider GetSliderById(int id)
        {
            return _sliderRepository.GetById(id);
        }

        /// <summary>
        /// Yeni bir Slider EKLEMEK.
        /// </summary>
        public void AddSlider(Slider slider)
        {
            _sliderRepository.Add(slider);
        }

        /// <summary>
        /// Mevcut bir Slider'ı GÜNCELLEMEK.
        /// </summary>
        public void UpdateSlider(Slider slider)
        {
            _sliderRepository.Update(slider);
        }

        /// <summary>
        /// Bir Slider'ı SİLMEK.
        /// </summary>
        public void DeleteSlider(int id)
        {
            // Silmek için önce nesneyi bulmamız lazım
            var sliderToDelete = _sliderRepository.GetById(id);
            if (sliderToDelete != null)
            {
                _sliderRepository.Delete(sliderToDelete);
            }
        }
    }
}
