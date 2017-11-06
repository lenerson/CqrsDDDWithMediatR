using AutoMapper;
using CqrsDDDWithMediatR.Domain.Models;
using CqrsDDDWithMediatR.ViewModels.User;

namespace CqrsDDDWithMediatR.Config
{
    public sealed class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<User, UserViewModel>();
        }
    }
}
