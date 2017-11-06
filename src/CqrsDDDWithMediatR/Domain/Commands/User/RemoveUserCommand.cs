using System;

namespace CqrsDDDWithMediatR.Domain.Commands.User
{
    public sealed class RemoveUserCommand : UserCommand
    {
        public RemoveUserCommand(Guid id) => Id = id;
    }
}
