using MediatR;
using System.Threading.Tasks;

namespace CqrsDDDWithMediatR.Domain.Notifications.User
{
    public sealed class UserNotificationHandler : IAsyncNotificationHandler<RegisteredUserNotification>
    {
        public async Task Handle(RegisteredUserNotification notification)
        {
            // TODO: Send mail

            await Task.CompletedTask;
        }
    }
}
