using System;

namespace CqrsDDDWithMediatR.Domain.Models
{
    public class User
    {
        #region Properties

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        #endregion
        #region Factories

        public static User CreateToInsert(string name, string email, string password) =>
            new User
            {
                Id = Guid.NewGuid(),
                Name = name,
                Email = email,
                Password = password
            };

        public static User CreateToUpdate(Guid id, string name, string email, string password) =>
            new User
            {
                Id = id,
                Name = name,
                Email = email,
                Password = password
            };

        #endregion
    }
}
