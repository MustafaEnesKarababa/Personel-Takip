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
    public class LoginBL : ICrud<Login>
    {
        public LoginBL()
        {
            db = new ProjeContext();
        }

        ProjeContext db;
        public void Add(Login entity)
        {
            db.Loginler.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int entityId)
        {
            db.Loginler.Remove(Find(entityId));
            db.SaveChanges();
        }

        public Login Find(int entityId)
        {
            return db.Loginler.Find(entityId);
        }

        public List<Login> GetAll()
        {
            return db.Loginler.ToList();
        }

        public void Update(Login entity)
        {
            db.Loginler.Update(entity);
            db.SaveChanges();
        }
        public DateTime? GetLoginDateById(int yetkiliId)
        {
            return db.Loginler.Where(a=>a.YetkiliId == yetkiliId).OrderByDescending(a=>a.GirisTarihi).Select(a=>a.GirisTarihi).FirstOrDefault();
        }
    }
}
