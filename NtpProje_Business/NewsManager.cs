using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NtpProje_Entities;
using NtpProje_DataAccess.Concrete;
using NtpProje_DataAccess;

namespace NtpProje_Business
{
    public class NewsManager
    {
        private readonly GenericRepository<news> _newsRepository;
        private readonly NtpProjeContext _context;

        public NewsManager()
        {
            _context = new NtpProjeContext();
            _newsRepository = new GenericRepository<news>(_context);
        }

        // --- ANA SİTE İÇİN GEREKLİ METOTLAR ---

        /// <summary>
        /// Ana sayfada (index.aspx) gösterilmek üzere
        /// AKTİF olan ve Yayın Tarihi'ne göre en yeniden eskiye
        /// sıralanmış haberleri getirir.
        /// </summary>
        public List<news> GetActiveNewsOrderedByDate()
        {
            // İş Kuralı: Aktif olanları getir ve tarihe göre tersten sırala.
            var newsList = _newsRepository.GetList(n => n.IsActive == true);
            return newsList.OrderByDescending(n => n.PublishDate).ToList();
        }

        /// <summary>
        /// Sadece belirtilen sayıda (take) aktif haberi getirir.
        /// (Örn: Ana sayfada son 4 haberi göstermek için)
        /// </summary>
        public List<news> GetActiveNewsOrderedByDate(int take)
        {
            var newsList = _newsRepository.GetList(n => n.IsActive == true);
            return newsList.OrderByDescending(n => n.PublishDate).Take(take).ToList();
        }


        // --- ADMİN PANELİ İÇİN GEREKLİ METOTLAR ---

        public List<news> GetAllNews()
        {
            return _newsRepository.GetAll();
        }

        public news GetNewsById(int id)
        {
            return _newsRepository.GetById(id);
        }

        public void AddNews(news News)
        {
            // Yeni haber eklendiğinde yayın tarihini o an olarak ayarla
            News.PublishDate = DateTime.Now;
            _newsRepository.Add(News);
        }

        public void UpdateNews(news News)
        {
            _newsRepository.Update(News);
        }

        public void DeleteNews(int id)
        {
            var newsToDelete = _newsRepository.GetById(id);
            if (newsToDelete != null)
            {
                _newsRepository.Delete(newsToDelete);
            }
        }
    }
}
