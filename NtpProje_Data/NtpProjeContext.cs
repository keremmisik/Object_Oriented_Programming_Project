using NtpProje_Entities; // Entity katmanımızı (9 sınıfımızı) kullanabilmek için!
using System;
using System.Collections.Generic;
using System.Data.Entity; // Entity Framework'ün ana kütüphanesi
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtpProje_DataAccess
{
    // Sınıfımızın DbContext'ten miras alması ŞART
    public class NtpProjeContext : DbContext
    {
        // Yapıcı Metot (Constructor)
        // Buradaki "NtpProjeDb" adı, Web.config dosyamıza 
        // yazacağımız connection string'in "name" özelliği olacak.
        public NtpProjeContext() : base("name=NtpProjeDb")
        {
        }

        // --- Veritabanı Tablolarımızı Temsil Edecek DbSet'ler ---
        // EF bu DbSellere bakarak veritabanında bu isimlerde 
        // tablolar oluşturmaya çalışacak.

        // Ana Sayfa için
        public virtual DbSet<Slider> Sliders { get; set; }
        public virtual DbSet<news> News { get; set; }

        // Çalışmalarımız (Portfolio) için
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<portfolio> Portfolios { get; set; }

        // Hakkımızda Sayfası için
        public virtual DbSet<about> Abouts { get; set; }
        public virtual DbSet<teammembers> TeamMembers { get; set; }

        // Hizmetlerimiz Sayfası için
        public virtual DbSet<service> Services { get; set; }

        // İletişim Sayfası için
        public virtual DbSet<contactmessage> ContactMessages { get; set; }
        public virtual DbSet<contactinfo> ContactInfos { get; set; }
    }
}