using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NtpProje_Entities
{
    public class contactinfo
    {
        [Key]
        public int ContactInfoID { get; set; } // ID'si her zaman 1 olacak

        [StringLength(500)]
        public string PageDescription { get; set; } // Formun üstündeki "Bu yazı site tasarımlarında..." metni

        // Harita yerine göstermek isteyeceğin diğer iletişim bilgileri
        // (Şu anki şablonda bunlar için yer yok, ama genellikle gerekir)
        [StringLength(300)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(150)]
        public string Email { get; set; } // Şirketin iletişim e-postası
    }
}
