using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NtpProje_Entities
{
    public class about
    {
        [Key]
        public int AboutID { get; set; } // Genellikle tek kayıt olacağı için ID'si hep 1 olur.

        [StringLength(200)]
        public string Title { get; set; } // "Hakkımızda Başlık alanı"

        [StringLength(500)]
        public string Summary { get; set; } //  (kısa olan)

        // Uzun açıklama alanı. nvarchar(MAX) olması için
        [Column(TypeName = "nvarchar(MAX)")]
        public string MainDescription { get; set; } // Paragraflı uzun metin

        [StringLength(300)]
        public string TeamSectionSubtitle { get; set; } // "Ekibimiz ile ilgili bir açıklama gelecek..."
    }
}
