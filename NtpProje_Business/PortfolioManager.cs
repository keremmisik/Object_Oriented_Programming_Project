using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NtpProje_Entities;
using NtpProje_DataAccess.Concrete;
using NtpProje_DataAccess;
using System.Data.Entity; // Include() metodu için bu gerekli!

namespace NtpProje_Business
{
    public class PortfolioManager
    {
        private readonly GenericRepository<portfolio> _portfolioRepository;
        private readonly NtpProjeContext _context;

        public PortfolioManager()
        {
            _context = new NtpProjeContext();
            _portfolioRepository = new GenericRepository<portfolio>(_context);
        }

        // --- ANA SİTE İÇİN GEREKLİ METOTLAR ---

        /// <summary>
        /// Sitede gösterilmek üzere AKTİF olan ve
        /// Çalışma Tarihi'ne (WorkDate) göre en yeniden eskiye sıralanmış 
        /// çalışmaları getirir.
        /// </summary>
        public List<portfolio> GetActivePortfoliosOrderedByDate()
        {
            // İş Kuralı: Aktif olanları getir ve tarihe göre tersten sırala.
            var portfolioList = _portfolioRepository.GetList(p => p.IsActive == true);
            return portfolioList.OrderByDescending(p => p.WorkDate).ToList();
        }

        /// <summary>
        /// "calismalarimiz.aspx" sayfasındaki gibi, 
        /// Kategori bilgisiyle birlikte (Include) listeleme yapar.
        /// </summary>
        public List<portfolio> GetActivePortfoliosWithCategory()
        {
            // Repository'yi burada doğrudan kullanmıyoruz çünkü "Include"
            // (ilişkili tabloyu çekme) işlemi yapacağız.
            // Bu özel bir sorgu olduğu için context'i kullanmak daha iyidir.
            return _context.Portfolios
                           .Include(p => p.Category) // Kategori bilgisini de SQL'e dahil et
                           .Where(p => p.IsActive == true)
                           .OrderByDescending(p => p.WorkDate)
                           .ToList();
        }

        /// <summary>
        /// "calismalarimiz_detay.aspx" sayfası için,
        /// ID'ye göre tek bir çalışmayı Kategori bilgisiyle getirir.
        /// </summary>
        public portfolio GetPortfolioByIdWithCategory(int id)
        {
            return _context.Portfolios
                           .Include(p => p.Category)
                           .FirstOrDefault(p => p.PortfolioID == id);
        }


        // --- ADMİN PANELİ İÇİN GEREKLİ METOTLAR ---

        public List<portfolio> GetAllPortfolios()
        {
            return _portfolioRepository.GetAll();
        }

        public portfolio GetPortfolioById(int id)
        {
            // Admin panelinde düzenleme yaparken Kategori bilgisi gerekmezse
            // bu metot daha hızlı çalışır.
            return _portfolioRepository.GetById(id);
        }

        public void AddPortfolio(portfolio portfolio)
        {
            _portfolioRepository.Add(portfolio);
        }

        public void UpdatePortfolio(portfolio portfolio)
        {
            _portfolioRepository.Update(portfolio);
        }

        public void DeletePortfolio(int id)
        {
            var portfolioToDelete = _portfolioRepository.GetById(id);
            if (portfolioToDelete != null)
            {
                _portfolioRepository.Delete(portfolioToDelete);
            }
        }
    }
}