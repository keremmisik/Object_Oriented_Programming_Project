using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NtpProje_Entities
{
    public class news
    {
        [Key]
        public int NewsID { get; set; }

        [StringLength(200)]
        public string Title { get; set; } // Haber Başlığı

        [StringLength(500)]
        public string Summary { get; set; } // Ana sayfada görünen kısa özet yazı

        public string FullContent { get; set; } // Detay sayfasında gösterilecek haberin tamamı

        [StringLength(250)]
        public string ImagePath { get; set; } // img/blog/small-1.jpg
        public bool IsActive { get; set; }

        public DateTime PublishDate { get; set; } // Haber yayın tarihi (Mart 22, 2013)

    }
}
