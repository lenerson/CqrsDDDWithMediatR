using System.Threading.Tasks;

namespace CqrsDDDWithMediatR.Domain.Interfaces.Repositories.Common
{
    public interface IUpdatableRepository<TEntity> where TEntity : class
    {
        Task Update(TEntity entity);
    }
}
