using System;
using System.Threading.Tasks;

namespace CqrsDDDWithMediatR.Domain.Interfaces.Repositories.Common
{
    public interface IRemovableRepository<TEntity> where TEntity : class
    {
        Task Remove(Guid id);
    }
}
