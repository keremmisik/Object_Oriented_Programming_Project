using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; // DbContext için
using System.Linq.Expressions;
using NtpProje_DataAccess.Abstract; // IGenericRepository için
using NtpProje_Entities; // Entity'ler için

namespace NtpProje_DataAccess.Concrete
{
    // Bu sınıf, IGenericRepository'deki tüm metotları UYGULAMAK zorundadır.
    // T, Slider, News, Portfolio vb. herhangi bir class olabilir.
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        // Veritabanı bağlamımızı (Context) çağırıyoruz
        protected readonly NtpProjeContext _context;
        // DbSet'i (tabloyu) temsil eden değişken
        protected readonly DbSet<T> _dbSet; 
        
        public GenericRepository(NtpProjeContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>(); // Gelen T tipine göre (örn: Slider) tabloyu seç
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges(); // Her işlemden sonra kaydet
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public List<T> GetList(Expression<Func<T, bool>> filter)
        {
            // filter (x => x.IsActive == true) sorgusuna göre filtrele ve listele
            return _dbSet.Where(filter).ToList();
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}