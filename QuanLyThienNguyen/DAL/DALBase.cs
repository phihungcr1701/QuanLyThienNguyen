using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThienNguyen.DAL
{
    public abstract class DALBase<T> where T : class
    {
        protected DataContext db = new DataContext();
        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }
        public void Add(T item)
        {
            db.Set<T>().Add(item);
            db.SaveChanges();
        }
        public void Update(T item)
        {
            var obj = db.Set<T>().Find(GetEntityKey(item));
            if (obj != null)
            {
                db.Entry(obj).CurrentValues.SetValues(item);
                db.SaveChanges();
            }
        }
        public void Delete(T item)
        {
            var obj = db.Set<T>().Find(GetEntityKey(item));
            if (obj != null)
            {
                db.Set<T>().Remove(obj);
                db.SaveChanges();
            }
        }
        protected abstract object GetEntityKey(T entity);
    }
}
