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
    internal class DepartmanCfg : IEntityTypeConfiguration<Departman>
    {
        public void Configure(EntityTypeBuilder<Departman> builder)
        {
            builder.Property(a=>a.DepartmanAdi).HasMaxLength(64);

            builder.HasData(
                new Departman() { DepartmanId = 1, DepartmanAdi = "Muhasebe"},
                new Departman() { DepartmanId = 2, DepartmanAdi = "İnsan Kaynakları" },
                new Departman() { DepartmanId = 3, DepartmanAdi = "Finans" }
                );
        }
    }
}
