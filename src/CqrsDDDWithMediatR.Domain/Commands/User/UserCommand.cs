using MediatR;
using System;

namespace CqrsDDDWithMediatR.Domain.Commands.User
{
    public abstract class UserCommand : IRequest
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public string Email { get; protected set; }
        public string Password { get; protected set; }
    }
}
