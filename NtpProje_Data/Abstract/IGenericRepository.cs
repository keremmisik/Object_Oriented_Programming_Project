using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions; // Expression için
using NtpProje_Entities; // BaseEntity sınıfı için (birazdan ekleyeceğiz)

namespace NtpProje_DataAccess.Abstract
{
    // T, "type" (tip) demektir ve bir class olmalıdır (where T : class)
    public interface IGenericRepository<T> where T : class
    {
        // Tüm listeyi getirmek için
        List<T> GetAll();

        // ID'ye göre tek bir nesne getirmek için
        T GetById(int id);

        // Yeni nesne EKLEMEK için
        void Add(T entity);

        // Nesne GÜNCELLEMEK için
        void Update(T entity);

        // Nesne SİLMEK için
        void Delete(T entity);

        // --- Gelişmiş Filtreleme Metodu ---
        // LINQ sorgularını (Lambda Expression) parametre olarak alabilen
        // sihirli metot.
        // Örn: Getir(x => x.IsActive == true && x.CategoryID == 2)
        List<T> GetList(Expression<Func<T, bool>> filter);
    }
}
