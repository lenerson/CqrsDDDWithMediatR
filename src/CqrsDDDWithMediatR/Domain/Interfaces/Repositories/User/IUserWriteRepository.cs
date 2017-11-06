using CqrsDDDWithMediatR.Domain.Interfaces.Repositories.Common;

namespace CqrsDDDWithMediatR.Domain.Interfaces.Repositories.User
{
    public interface IUserWriteRepository :
        IInsertableRepository<Models.User>, IUpdatableRepository<Models.User>, IRemovableRepository<Models.User>
    {
    }
}
