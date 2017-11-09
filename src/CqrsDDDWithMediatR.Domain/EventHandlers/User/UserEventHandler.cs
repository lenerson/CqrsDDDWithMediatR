using CqrsDDDWithMediatR.Domain.Events.User;
using MediatR;
using System.Threading.Tasks;

namespace CqrsDDDWithMediatR.Domain.Notifications.User
{
    public sealed class UserEventHandler : IAsyncNotificationHandler<RegisteredUserEvent>
    {
        public async Task Handle(RegisteredUserEvent notification)
        {
            // TODO: Send mail

            await Task.CompletedTask;
        }
    }
}
