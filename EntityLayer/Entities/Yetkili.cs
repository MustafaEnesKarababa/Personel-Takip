using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Yetkili
    {
        public int YetkiliId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public int HataliGiris { get; set; }
        public AktifDurum AktifDurum { get; set; }
        public YetkiDurum YetkiDurum { get; set; }

    }
}
