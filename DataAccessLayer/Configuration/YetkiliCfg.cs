using EntityLayer.Entities;
using EntityLayer.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configuration
{
    internal class YetkiliCfg : IEntityTypeConfiguration<Yetkili>
    {
        public void Configure(EntityTypeBuilder<Yetkili> builder)
        {
            builder.Property(a => a.HataliGiris).HasDefaultValue(0);
            builder.Property(a => a.AktifDurum).HasDefaultValue(AktifDurum.Aktif);

            builder.HasData(
                new Yetkili() { YetkiliId = 1, KullaniciAdi = "muhasebe@123", Sifre = "1234", YetkiDurum = YetkiDurum.Yetkili },
                new Yetkili() { YetkiliId = 2, KullaniciAdi = "admin@admin", Sifre = "admin@123", YetkiDurum = YetkiDurum.Admin }
                );
        }
    }
}
