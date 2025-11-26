using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NtpProje_Entities
{
    public class contactmessage
    {
        [Key]
        public int MessageID { get; set; }

        [StringLength(100)]
        public string FirstName { get; set; } // id="contact-name"

        [StringLength(100)]
        public string LastName { get; set; } // id="contact-lastname"

        [StringLength(150)]
        public string Email { get; set; } // id="contact-email"

        [StringLength(200)]
        public string Subject { get; set; } // id="contact-subject"

        [Column(TypeName = "nvarchar(MAX)")]
        public string Message { get; set; } // id="contact-message"

        // === İyi bir yönetim paneli için ekstra alanlar ===

        public DateTime SubmissionDate { get; set; } // Mesajın gönderilme tarihi

        public bool IsRead { get; set; } // Mesaj "okundu" olarak işaretlendi mi?
    }
}
