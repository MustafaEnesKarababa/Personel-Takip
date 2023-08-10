using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Login
    {
        public int LoginId { get; set; }
        public DateTime? GirisTarihi { get; set; }

        public int YetkiliId { get; set; }
        public Yetkili Yetkili { get; set; }
    }
}
