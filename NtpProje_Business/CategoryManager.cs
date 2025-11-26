using NtpProje_DataAccess;
using NtpProje_DataAccess.Concrete;
using NtpProje_Entities;
using NtpProje_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtpProje_Business
{
    public class CategoryManager
    {
        private readonly GenericRepository<Category> _categoryRepository;
        private readonly NtpProjeContext _context;

        public CategoryManager()
        {
            _context = new NtpProjeContext();
            _categoryRepository = new GenericRepository<Category>(_context);
        }

        // --- ANA SİTE İÇİN GEREKLİ METOTLAR ---

        /// <summary>
        /// Sitede (örn: calismalarimiz.aspx filtresi) gösterilmek üzere 
        /// AKTİF olan ve Sıra'ya göre dizilmiş kategorileri getirir.
        /// </summary>
        public List<Category> GetActiveCategoriesOrdered()
        {
            var categoryList = _categoryRepository.GetList(c => c.IsActive == true);
            return categoryList.OrderBy(c => c.Order).ToList();
        }

        // --- ADMİN PANELİ İÇİN GEREKLİ METOTLAR ---

        public List<Category> GetAllCategories()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public void AddCategory(Category category)
        {
            _categoryRepository.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            _categoryRepository.Update(category);
        }

        public void DeleteCategory(int id)
        {
            var categoryToDelete = _categoryRepository.GetById(id);
            if (categoryToDelete != null)
            {
                _categoryRepository.Delete(categoryToDelete);
            }
        }

        // Raporlama için Stored Procedure çağırır
        public List<CategoryReportDto> GetCategoryProjectCounts()
        {
            // Not: CategoryReportDto'nun altı kırmızı çizilirse, 
            // en üste 'using NtpProje_Entities;' eklediğinden emin ol.
            return _context.Database
                           .SqlQuery<CategoryReportDto>("EXEC GetCategoryProjectCounts")
                           .ToList();
        }
    }
}