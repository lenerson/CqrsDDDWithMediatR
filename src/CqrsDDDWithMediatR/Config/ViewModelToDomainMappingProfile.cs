using AutoMapper;
using CqrsDDDWithMediatR.Domain.Commands.User;
using CqrsDDDWithMediatR.ViewModels.User;

namespace CqrsDDDWithMediatR.Config
{
    public sealed class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UserViewModel, RegisterUserCommand>()
                .ConstructUsing(x => new RegisterUserCommand(x.Name, x.Email, x.Password));

            CreateMap<UserViewModel, UpdateUserCommand>()
                .ConstructUsing(x => new UpdateUserCommand(x.Id, x.Name, x.Email));
        }
    }
}
