using BusinessLayer.Interfaces;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.EntitiesBL
{
    public class YetkiliBL : ICrud<Yetkili>
    {
        public YetkiliBL()
        {
            db = new ProjeContext();
        }

        ProjeContext db;
        public void Add(Yetkili entity)
        {
            db.Yetkililer.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int entityId)
        {
            db.Yetkililer.Remove(Find(entityId));
            db.SaveChanges();
        }

        public Yetkili Find(int entityId)
        {
            return db.Yetkililer.Find(entityId);
        }

        public List<Yetkili> GetAll()
        {
           return db.Yetkililer.ToList();
        }

        public List<Yetkili> GetAllYetkili()
        {
            return db.Yetkililer.Where(x => x.YetkiDurum == YetkiDurum.Yetkili).ToList();
        }

        public void Update(Yetkili entity)
        {
            db.Yetkililer.Update(entity);
            db.SaveChanges();
        }
        public int Login(string kullaniciadi, string sifre)
        {
            Yetkili yetkili = db.Yetkililer.Where(a=>a.KullaniciAdi == kullaniciadi).SingleOrDefault();
            if(yetkili != null)
            {
                return yetkili.YetkiliId;
            }
            else
            {
                return -1;
            }
        }
    }
}
