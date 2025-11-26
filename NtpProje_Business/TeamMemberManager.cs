using NtpProje_DataAccess;
using NtpProje_DataAccess.Concrete;
using NtpProje_Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtpProje_Business
{
    public class TeamMemberManager
    {
        private readonly GenericRepository<teammembers> _teamRepository;
        private readonly NtpProjeContext _context;

        public TeamMemberManager()
        {
            _context = new NtpProjeContext();
            _teamRepository = new GenericRepository<teammembers>(_context);
        }

        // --- ANA SİTE ---
        public List<teammembers> GetActiveTeamMembersOrdered()
        {
            return _teamRepository.GetList(t => t.IsActive == true)
                                  .OrderBy(t => t.Order).ToList();
        }

        // --- ADMIN PANELİ ---
        public List<teammembers> GetAllTeamMembers()
        {
            return _teamRepository.GetAll();
        }

        public teammembers GetTeamMemberById(int id)
        {
            return _teamRepository.GetById(id);
        }

        public void AddTeamMember(teammembers Teammembers)
        {
            _teamRepository.Add(Teammembers);
        }

        public void UpdateTeamMember(teammembers Teammembers)
        {
            _teamRepository.Update(Teammembers);
        }

        public void DeleteTeamMember(int id)
        {
            var member = _teamRepository.GetById(id);
            if (member != null) _teamRepository.Delete(member);
        }
    }
}
