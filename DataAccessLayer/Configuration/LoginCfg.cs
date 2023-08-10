using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configuration
{
    internal class LoginCfg : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.HasData(
                new Login { LoginId = 1, GirisTarihi = Convert.ToDateTime("2023.06.06"), YetkiliId = 1},
                 new Login { LoginId = 2, GirisTarihi = Convert.ToDateTime("2023.06.07"), YetkiliId = 1 }
                );
        }
    }
}
