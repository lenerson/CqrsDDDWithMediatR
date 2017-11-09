using MediatR;

namespace CqrsDDDWithMediatR.Domain.Events.User
{
    public sealed class RegisteredUserEvent : INotification
    {
        public RegisteredUserEvent(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
    }
}
