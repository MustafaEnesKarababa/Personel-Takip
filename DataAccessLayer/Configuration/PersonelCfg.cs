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
    internal class PersonelCfg : IEntityTypeConfiguration<Personel>
    {
        public void Configure(EntityTypeBuilder<Personel> builder)
        {
            builder.HasIndex(a => a.TC).IsUnique();

            builder.HasData(
                new Personel() { PersonelId = 1, Ad = "Ahmet", Soyad = "Güler", TC = "11111111111", DogumTarihi = Convert.ToDateTime("1993.12.12"), Cinsiyet = Cinsiyet.Erkek, Mail = "ahmet@gmail.com", Telefon = "05554443322", Adres = "Kadıköy, İstanbul", DepartmanId = 1 },
                new Personel() { PersonelId = 2, Ad = "Ayşe", Soyad = "Yılmaz", TC = "22222222222", DogumTarihi = Convert.ToDateTime("1996.06.06"), Cinsiyet = Cinsiyet.Kadın, DepartmanId = 3 }
                );
        }
        
    }
}
