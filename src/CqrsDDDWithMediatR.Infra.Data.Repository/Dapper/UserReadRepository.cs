using CqrsDDDWithMediatR.Domain.Interfaces.Repositories.User;
using CqrsDDDWithMediatR.Domain.Models;
using CqrsDDDWithMediatR.Infra.Data.Repository.Common;
using Dapper;
using System;
using System.Threading.Tasks;

namespace CqrsDDDWithMediatR.Infra.Data.Repository.Dapper
{
    public sealed class UserReadRepository : ReadRepository<User>, IUserReadRepository
    {
        public async Task<bool> ExistUserByEmail(Guid id, string email)
        {
            using (var connection = GetConnection())
            {
                var count = await connection.ExecuteScalarAsync<int>(
                    sql: "SELECT COUNT(Id) FROM Users WHERE Id != @id AND Email = @email",
                    param: new { id = id, email = email }
                );

                return count >= 1;
            }
        }
    }
}
