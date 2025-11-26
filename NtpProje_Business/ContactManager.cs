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
    public class ContactManager
    {
        // İki farklı tabloyu yöneteceği için iki repository tanımlıyoruz
        private readonly GenericRepository<contactinfo> _infoRepository;
        private readonly GenericRepository<contactmessage> _messageRepository;
        private readonly NtpProjeContext _context;

        public ContactManager()
        {
            _context = new NtpProjeContext();
            _infoRepository = new GenericRepository<contactinfo>(_context);
            _messageRepository = new GenericRepository<contactmessage>(_context);
        }

        // --- İLETİŞİM BİLGİLERİ (ContactInfo) CRUD ---

        // HATA ÇÖZÜMÜ 1: Tek kaydı getirmek için (UI'da hata veren metot)
        public contactinfo GetContactInfoById(int id)
        {
            return _infoRepository.GetById(id);
        }

        // Tekil kaydı ilk kez formu doldurmak için getirir
        public contactinfo GetFirstContactInfo()
        {
            return _infoRepository.GetAll().FirstOrDefault();
        }

        // HATA ÇÖZÜMÜ 2: Yeni kayıt eklemek için (UI'da hata veren metot)
        public void AddContactInfo(contactinfo info)
        {
            _infoRepository.Add(info);
        }

        public void UpdateContactInfo(contactinfo info)
        {
            _infoRepository.Update(info);
        }


        // --- GELEN MESAJLAR ---

        // Ziyaretçi mesaj gönderdiğinde çalışacak
        public void AddMessage(contactmessage message)
        {
            message.SubmissionDate = DateTime.Now; // Tarihi otomatik ata
            message.IsRead = false; // Başlangıçta okunmadı olarak işaretle
            _messageRepository.Add(message);
        }

        // Admin panelinde gelen mesajları listelemek için
        public List<contactmessage> GetAllMessages()
        {
            return _messageRepository.GetAll().OrderByDescending(x => x.SubmissionDate).ToList();
        }

        // Admin bir mesajı okuduğunda veya sildiğinde
        public contactmessage GetMessageById(int id)
        {
            return _messageRepository.GetById(id);
        }

        public void DeleteMessage(int id)
        {
            var msg = _messageRepository.GetById(id);
            if (msg != null) _messageRepository.Delete(msg);
        }

        // Mesajı "Okundu" olarak işaretlemek için
        public void MarkAsRead(int id)
        {
            var msg = _messageRepository.GetById(id);
            if (msg != null)
            {
                msg.IsRead = true;
                _messageRepository.Update(msg);
            }
        }
    }
}
