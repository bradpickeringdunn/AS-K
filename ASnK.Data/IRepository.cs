using System;
using System.Data.Entity;
using System.Linq;

namespace ASnK.Data
{
    public interface IRepository<TEntity, TContext>
        where TEntity : class
        where TContext : DbContext, IDisposable
    {
        IQueryable<TEntity> GetAll();

        void Update(TEntity entity);

        void Dispose();
    }
}
