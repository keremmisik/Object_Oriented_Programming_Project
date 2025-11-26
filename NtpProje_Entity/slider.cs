using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace NtpProje_Entities
{
    public class Slider
    {
        [Key]
        public int SliderID { get; set; }

        [StringLength(250)]
        public string ImagePath { get; set; } // img/slider/slide11.jpg

        [StringLength(150)]
        public string Title { get; set; } // Başlık gelecek bu alana gelecek!

        [StringLength(100)]
        public string Line1 { get; set; } // Madde 1

        [StringLength(100)]
        public string Line2 { get; set; } // Madde 2

        [StringLength(100)]
        public string Line3 { get; set; } // Madde 3
        public int Order { get; set; }
        public bool IsActive { get; set; }
    }
}
