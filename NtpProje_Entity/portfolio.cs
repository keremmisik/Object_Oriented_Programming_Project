using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NtpProje_Entities
{
    public class portfolio
    {
        [Key]
        public int PortfolioID { get; set; }

        [StringLength(150)]
        public string Title { get; set; } // Çalışma Başlığı

        // Detay sayfasında (calismalarimiz_detay.aspx) gösterilecek uzun açıklama
        [Column(TypeName = "nvarchar(MAX)")] // nvarchar(MAX) olarak ayarladık
        public string Description { get; set; }

        [StringLength(250)]
        public string ThumbnailPath { get; set; } // Küçük resim (listeleme için)

        [StringLength(250)]
        public string LargeImagePath { get; set; } // Ana büyük resim (detay sayfası için)

        public DateTime WorkDate { get; set; } // Çalışmanın yapılma tarihi

        [StringLength(150)]
        public string Client { get; set; } // Müşteri İsmi - YENİ EKLENDİ

        [StringLength(250)]
        public string Technologies { get; set; } // Kullanılan Teknolojiler - YENİ EKLENDİ
        public bool IsActive { get; set; }

        // Foreign Key İlişkisi
        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; } // Navigation Property
    }
}
