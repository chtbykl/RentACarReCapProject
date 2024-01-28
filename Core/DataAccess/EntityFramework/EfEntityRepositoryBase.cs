using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContoext> : IEntityRepository<TEntity>
        where TEntity : class,IEntity, new()
        where TContoext :DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContoext context = new TContoext() )
            {
                var entityToAdd = context.Entry( entity );
                entityToAdd.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContoext context = new TContoext())
            {
                var entityToDelete = context.Entry(entity);
                entityToDelete.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using(TContoext context = new TContoext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
            
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContoext context = new TContoext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContoext context = new TContoext())
            {
                var entityToUpdate = context.Entry(entity);
                entityToUpdate.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
