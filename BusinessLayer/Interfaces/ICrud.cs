using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    internal interface ICrud<T> where T : class
    {
        public List<T> GetAll();
        public void Add(T entity);
        public void Delete(int entityId);
        public void Update(T entity);
        public T Find(int entityId);
    }
}
