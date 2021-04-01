using CoreAndFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreAndFood.Repositories
{
    public class GenericRepository<T> where T: class,new()
    {
        Context db = new Context();

        public void TAdd(T t)
        {
            db.Set<T>().Add(t);
            db.SaveChanges();
        }
        public void TDelete(T t)
        {
            db.Set<T>().Remove(t);
            db.SaveChanges();
        }
        public void TUpdate(T t)
        {
            db.Set<T>().Update(t);
            db.SaveChanges();
        }
        public List<T> tList()
        {
            return db.Set<T>().ToList();
        }
        public T TGet(int id)
        {
            return db.Set<T>().Find(id);
        }
        public List<T> tList(string p)
        {
            return db.Set<T>().Include(p).ToList();
        }
    }
}
