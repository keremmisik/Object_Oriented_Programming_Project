using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NtpProje_Entities
{
    public class teammembers
    {
        [Key]
        public int TeamMemberID { get; set; }

        [StringLength(100)]
        public string FullName { get; set; } // Örn: "Orhan Solmaz"

        [StringLength(100)]
        public string Position { get; set; } // Örn: "Genel Müdür"

        [StringLength(250)]
        public string ImagePath { get; set; } // Örn: "img/about/team1.jpg"

        [StringLength(500)]
        public string Biography { get; set; } // Karttaki kısa açıklama 
        public int Order { get; set; }
        public bool IsActive { get; set; }
    }
}
