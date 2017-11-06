using System;

namespace CqrsDDDWithMediatR.Domain.Commands.User
{
    public sealed class UpdateUserCommand : UserCommand
    {
        public UpdateUserCommand(Guid id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
}
