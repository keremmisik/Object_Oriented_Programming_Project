using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NtpProje_Entities
{
    public class service
    {
        [Key]
        public int ServiceID { get; set; }

        [StringLength(150)]
        public string Title { get; set; } // "Hizmetlerimiz Başlık"

        [StringLength(250)]
        public string Subtitle { get; set; } // "Alt Açıklama"

        [StringLength(500)]
        public string Description { get; set; } // Paragraf şeklindeki uzun açıklama

        [StringLength(50)]
        public string IconClass { get; set; } // Örn: "icon-desktop", "icon-cogs"
        public int Order { get; set; }
        public bool IsActive { get; set; }

    }
}
