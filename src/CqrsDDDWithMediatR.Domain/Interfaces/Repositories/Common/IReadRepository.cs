using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CqrsDDDWithMediatR.Domain.Interfaces.Repositories.Common
{
    public interface IReadRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetById(Guid id);
        Task<IEnumerable<TEntity>> GetAll();
    }
}
