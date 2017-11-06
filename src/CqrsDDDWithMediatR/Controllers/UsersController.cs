using AutoMapper;
using CqrsDDDWithMediatR.Domain.Commands.User;
using CqrsDDDWithMediatR.Domain.Interfaces.Repositories.User;
using CqrsDDDWithMediatR.ViewModels.User;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CqrsDDDWithMediatR.Controllers
{
    [Produces("application/json")]
    [Route("api/Users")]
    public class UsersController : Controller
    {
        private readonly IMapper mapper;
        private readonly IMediator mediator;
        private readonly IUserReadRepository userReadRepository;

        public UsersController(
            IMapper mapper,
            IMediator mediator,
            IUserReadRepository userReadRepository)
        {
            this.mapper = mapper;
            this.mediator = mediator;
            this.userReadRepository = userReadRepository;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<IEnumerable<UserViewModel>> Get() =>
            mapper.Map<IEnumerable<UserViewModel>>(await userReadRepository.GetAll());

        // GET: api/Users/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<UserViewModel> Get(Guid id) =>
            mapper.Map<UserViewModel>(await userReadRepository.GetById(id));

        // POST: api/Users
        [HttpPost]
        public async Task Post([FromBody]UserViewModel viewModel) =>
            await mediator.Send(mapper.Map<RegisterUserCommand>(viewModel));

        // PUT: api/Users/5
        [HttpPut]
        public async Task Put([FromBody]UserViewModel viewModel) =>
            await mediator.Send(mapper.Map<UpdateUserCommand>(viewModel));

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task Delete(Guid id) => await mediator.Send(new RemoveUserCommand(id));
    }
}
