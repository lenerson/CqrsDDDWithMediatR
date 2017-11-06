using CqrsDDDWithMediatR.Domain.Interfaces.Repositories.Common;
using CqrsDDDWithMediatR.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace CqrsDDDWithMediatR.Infra.Data.Repository.Common
{
    public abstract class WriteRepository<TEntity> :
        IInsertableRepository<TEntity>,
        IUpdatableRepository<TEntity>,
        IRemovableRepository<TEntity> where TEntity : class
    {
        private readonly CqrsDDDWithMediatRContext context;
        private readonly DbSet<TEntity> dbSet;

        protected WriteRepository()
        {
            context = new CqrsDDDWithMediatRContext();
            dbSet = context.Set<TEntity>();
        }
        public async Task Add(TEntity entity)
        {
            await dbSet.AddAsync(entity);
            await context.SaveChangesAsync();
        }
        public async Task Update(TEntity entity)
        {
            dbSet.Update(entity);
            await context.SaveChangesAsync();
        }
        public async Task Remove(Guid id)
        {
            dbSet.Remove(await dbSet.FindAsync(id));
            await context.SaveChangesAsync();
        }
    }
}
