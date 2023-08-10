using BusinessLayer.Interfaces;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.EntitiesBL
{
    public class PersonelBL : ICrud<Personel>
    {
        public PersonelBL()
        {
            db = new ProjeContext();
        }

        ProjeContext db;
        public void Add(Personel entity)
        {
            db.Personeller.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int entityId)
        {
            db.Personeller.Remove(Find(entityId));
            db.SaveChanges();
        }

        public Personel Find(int entityId)
        {
            return db.Personeller.Find(entityId);
        }

        public List<Personel> GetAll()
        {
            return db.Personeller.ToList();
        }

        public void Update(Personel entity)
        {
            db.Personeller.Update(entity);
            db.SaveChanges();
        }
        public List<Personel> GetByText(string text)
        {
            return db.Personeller.Where(a=>a.Ad.Contains(text) || a.Soyad.Contains(text) || a.Adres.Contains(text) || a.TC.Contains(text)).ToList();   
        }
        public bool CheckTC(string Tc)
        {
            Personel personel = db.Personeller.Where(a=> a.TC == Tc).SingleOrDefault();

            if (personel != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
