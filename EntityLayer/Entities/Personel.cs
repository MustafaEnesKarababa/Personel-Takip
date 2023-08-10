using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Personel
    {
        public int PersonelId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public DateTime DogumTarihi { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public string? Mail { get; set; }
        public string? Telefon { get; set; }
        public string? Adres { get; set; }

        public int DepartmanId { get; set; }
        public Departman Departman { get; set; }
    }
}
