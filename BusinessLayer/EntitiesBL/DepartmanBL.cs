using BusinessLayer.ContextBL;
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
    public class DepartmanBL : ICrud<Departman>
    {
        public DepartmanBL()
        {
            db = new ProjeContext();
        }

        ProjeContext db;
        public void Add(Departman entity)
        {
            db.Departmanlar.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int entityId)
        {
            db.Departmanlar.Remove(Find(entityId));
            db.SaveChanges();
        }

        public Departman Find(int entityId)
        {
            return db.Departmanlar.Find(entityId);
        }

        public List<Departman> GetAll()
        {
           return db.Departmanlar.ToList();
        }

        public void Update(Departman entity)
        {
            db.Departmanlar.Update(entity);
            db.SaveChanges();
        }
    }
}
