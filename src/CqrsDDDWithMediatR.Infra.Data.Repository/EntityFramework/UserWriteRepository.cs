using CqrsDDDWithMediatR.Domain.Interfaces.Repositories.User;
using CqrsDDDWithMediatR.Domain.Models;
using CqrsDDDWithMediatR.Infra.Data.Repository.Common;

namespace CqrsDDDWithMediatR.Infra.Data.Repository.EntityFramework
{
    public sealed class UserWriteRepository : WriteRepository<User>, IUserWriteRepository
    {
    }
}
