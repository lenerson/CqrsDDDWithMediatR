using CqrsDDDWithMediatR.Domain.Interfaces.Repositories.User;
using CqrsDDDWithMediatR.Domain.Notifications.User;
using MediatR;
using System;
using System.Threading.Tasks;

namespace CqrsDDDWithMediatR.Domain.Commands.User
{
    public sealed class UserCommandHandler :
        IAsyncRequestHandler<RegisterUserCommand>,
        IAsyncRequestHandler<UpdateUserCommand>,
        IAsyncRequestHandler<RemoveUserCommand>
    {
        private readonly IMediator mediator;
        private readonly IUserReadRepository userReadRepository;
        private readonly IUserWriteRepository userWriteRepository;

        public UserCommandHandler(
            IMediator mediator,
            IUserReadRepository userReadRepository,
            IUserWriteRepository userWriteRepository)
        {
            this.mediator = mediator;
            this.userReadRepository = userReadRepository;
            this.userWriteRepository = userWriteRepository;
        }

        public async Task Handle(RegisterUserCommand message)
        {
            var existingUser = await userReadRepository.ExistUserByEmail(message.Id, message.Email);
            if (existingUser)
                throw new Exception("User already exists with this email.");

            await userWriteRepository.Add(Models.User.CreateToInsert(message.Name, message.Email, message.Password));

            await mediator.Publish(new RegisteredUserNotification(message.Name, message.Email));
        }
        public async Task Handle(UpdateUserCommand message)
        {
            var existingUser = await userReadRepository.GetById(message.Id);
            if (existingUser == null)
                throw new Exception("User not exists."); ;

            if (await userReadRepository.ExistUserByEmail(message.Id, message.Email))
                throw new Exception("User already exists with this email.");

            await userWriteRepository.Update(
                Models.User.CreateToUpdate(message.Id, message.Name, message.Email, existingUser.Password)
            );
        }
        public async Task Handle(RemoveUserCommand message) =>
            await userWriteRepository.Remove(message.Id);
    }
}
