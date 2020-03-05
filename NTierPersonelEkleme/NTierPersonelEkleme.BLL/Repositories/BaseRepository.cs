using NTierPersonelEkleme.DAL.ORM.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierPersonelEkleme.BLL.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        ProjectContext db = new ProjectContext();
        //Singletion design patternı uygulandı
        private BaseRepository()
        {

        }
        private static BaseRepository<T> nesne = new BaseRepository<T>();
        public static BaseRepository<T> Nesne
        {
            get
            {
                return nesne;
            }
        }
        public void Add(T item)
        {
            db.Set(typeof(T)).Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Set(typeof(T)).Remove(SelectById(id));
        }

        public List<T> SelectAll()
        {
            return db.Set(typeof(T)).Cast<T>().ToList();
        }

        public T SelectById(int id)
        {
            return db.Set(typeof(T)).Cast<T>().Find(id);
        }

        public void Update(T item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

        }
    }
}
