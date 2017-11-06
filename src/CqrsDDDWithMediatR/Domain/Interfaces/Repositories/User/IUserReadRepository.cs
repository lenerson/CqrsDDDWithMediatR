using CqrsDDDWithMediatR.Domain.Interfaces.Repositories.Common;
using System;
using System.Threading.Tasks;

namespace CqrsDDDWithMediatR.Domain.Interfaces.Repositories.User
{
    public interface IUserReadRepository : IReadRepository<Models.User>
    {
        Task<bool> ExistUserByEmail(Guid id, string email);
    }
}
