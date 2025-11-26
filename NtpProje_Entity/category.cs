using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NtpProje_Entities
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [StringLength(100)]
        public string CategoryName { get; set; }

        // Navigation Property: Bir kategorinin birden fazla portfolio'su olabilir
        public virtual ICollection<portfolio> Portfolios { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }
    }
}
