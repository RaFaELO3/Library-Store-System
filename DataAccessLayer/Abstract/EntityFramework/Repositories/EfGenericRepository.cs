using DataAccessLayer.Abstract.EntityFramework.Context;
using DataAccessLayer.Concrete;
using Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Abstract.EntityFramework.Repositories
{
    public class EfGenericRepository<TEntity> : IGenericDAL<TEntity> where TEntity : class, ITable, new()
    {
        public void Add(TEntity entity)
        {
            using (var context = new StoreContext())
            {
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new StoreContext())
            {
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            }
        }

        public List<TEntity> Get()
        {
            using (var context = new StoreContext())
            {
                var result = context.Set<TEntity>().ToList();
                return result;
            }
        }

        public TEntity GetById(int id)
        {
            using (var context = new StoreContext())
            {
                var result = context.Set<TEntity>().Find(id);
                return result;
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new StoreContext())
            {
                context.Set<TEntity>().Update(entity);
                context.SaveChanges();
            }
        }
    }
}
