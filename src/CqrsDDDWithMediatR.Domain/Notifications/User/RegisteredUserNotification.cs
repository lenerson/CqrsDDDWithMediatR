using MediatR;

namespace CqrsDDDWithMediatR.Domain.Notifications.User
{
    public sealed class RegisteredUserNotification : INotification
    {
        public RegisteredUserNotification(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
    }
}
