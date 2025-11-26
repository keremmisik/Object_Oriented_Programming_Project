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
    public class ServiceManager
    {
        private readonly GenericRepository<service> _serviceRepository;
        private readonly NtpProjeContext _context;

        public ServiceManager()
        {
            _context = new NtpProjeContext();
            _serviceRepository = new GenericRepository<service>(_context);
        }

        // --- ANA SİTE ---
        public List<service> GetActiveServicesOrdered()
        {
            return _serviceRepository.GetList(s => s.IsActive == true)
                                     .OrderBy(s => s.Order).ToList();
        }

        // --- ADMIN PANELİ ---
        public List<service> GetAllServices()
        {
            return _serviceRepository.GetAll();
        }

        public service GetServiceById(int id)
        {
            return _serviceRepository.GetById(id);
        }

        public void AddService(service Service)
        {
            _serviceRepository.Add(Service);
        }

        public void UpdateService(service Service)
        {
            _serviceRepository.Update(Service);
        }

        public void DeleteService(int id)
        {
            var service = _serviceRepository.GetById(id);
            if (service != null) _serviceRepository.Delete(service);
        }
    }
}
