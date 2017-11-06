using System.Threading.Tasks;

namespace CqrsDDDWithMediatR.Domain.Interfaces.Repositories.Common
{
    public interface IInsertableRepository<TEntity> where TEntity : class
    {
        Task Add(TEntity entity);
    }
}
