using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new Context(); // Context sınıfı DbContex'i miras aldığından buradaki Add,Remove,Insert,Update
                                          //fonksiyonları DbContex'in meta verilerinde gelir
            c.Remove(t);                   // using var ile kullanımında ise  
            c.SaveChanges();
        }

        public T GetByID(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
            
        }

        public List<T> GetListAll()
        {
            using var c = new Context();
            return c.Set<T>().ToList(); // tabloya erişebilmek için set<> komutunu kullanmamız gerekiyor

        }

        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();

        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();

        }
    }
}
