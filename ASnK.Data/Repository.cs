using System;
using System.Data.Entity;
using System.Linq;

namespace ASnK.Data
{
    public class Repository<TEntity, TContext> : IRepository<TEntity, TContext> 
        where TEntity : class
        where TContext: DbContext
    {
        private readonly DbContext context;
        private IDbSet<TEntity> entities;

        public Repository(TContext context)
        {
            this.context = context;
            this.entities = context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return entities;
        }

        public void Update(TEntity entity)
        {
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Dispose()
        {
            if(context != null)
            {
                context.Dispose();
            }
        }

        public virtual IQueryable<TEntity> Table
        {
            get
            {
                return this.Entities;
            }
        }

        private IDbSet<TEntity> Entities
        {
            get
            {
                if (entities == null)
                {
                    entities = context.Set<TEntity>();
                }
                return entities;
            }
        }
    }
}
