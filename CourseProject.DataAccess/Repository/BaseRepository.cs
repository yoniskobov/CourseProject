using CourseProject.DB.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DataAccess.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected DbContext Context;

        protected DbSet<T> DBSet;

        public BaseRepository(DbContext ctx)
        {
            Context = ctx;
            DBSet = Context.Set<T>();
        }

        public BaseRepository()
        {
        }

        public List<T> GetAll() => Context.Set<T>().ToList();
        public T GetByID(int id) => Context.Set<T>().Find(id);
        public void Create(T item)
        {
            Context.Set<T>().Add(item);
            Context.SaveChanges();
        }
        public void Update(T item, Func<T, bool> findByIDPredecate)
        {
            var local = Context.Set<T>()
                            .Local
                            .FirstOrDefault(findByIDPredecate);
            if (local != null)
            {
                Context.Entry(local).State = EntityState.Detached;
            }

            Context.Entry(item).State = EntityState.Modified;


            Context.SaveChanges();
        }
        public bool DeleteByID(int id)
        {
            bool isDeleted = false;
            T dbItem = Context.Set<T>().Find(id);
            if (dbItem != null)
            {
                Context.Set<T>().Remove(dbItem);
                int recordsChanged = Context.SaveChanges();
                isDeleted = recordsChanged > 0;
            }
            return isDeleted;
        }
        public void Save(T item)
        {
            if (item.Id == 0)
            {
                Create(item);
                return;
            }
            Update(item, x => x.Id == item.Id);
        } 

    }
}
