using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class ProjeContext : DbContext
    {
        public DbSet<Departman> Departmanlar { get; set; }
        public DbSet<Login> Loginler { get; set; }

        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Yetkili> Yetkililer { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=PersonelTakipDb;Integrated Security=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProjeContext).Assembly);
        }
    }
}
