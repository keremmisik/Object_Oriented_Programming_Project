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
    public class AboutManager
    {
        private readonly GenericRepository<about> _aboutRepository;
        private readonly NtpProjeContext _context;

        public AboutManager()
        {
            _context = new NtpProjeContext();
            _aboutRepository = new GenericRepository<about>(_context);
        }

        // --- ANA SİTE ---
        // Hakkımızda yazısı genelde 1 tanedir, ilkini çekeriz.
        public about GetFirstAbout()
        {
            return _aboutRepository.GetAll().FirstOrDefault();
        }

        public about GetAboutById(int id)
        {
            return _aboutRepository.GetById(id);
        }

        // --- ADMIN PANELİ ---
        // Admin panelinde güncelleme yapmak için
        public void UpdateAbout(about About)
        {
            _aboutRepository.Update(About);
        }

        // Eğer hiç kayıt yoksa admin panelinden eklemek için
        public void AddAbout(about About)
        {
            _aboutRepository.Add(About);
        }
    }
}
