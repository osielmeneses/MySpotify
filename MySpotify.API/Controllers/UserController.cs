using MediatR;
using Microsoft.AspNetCore.Mvc;
using MySpotify.Application.Users.Dto;
using MySpotify.Application.Users.Handler.Commands;


namespace MySpotify.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IMediator Handler { get; }

        public UserController(IMediator handler)
        {
            Handler = handler;
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserInputDto inputDto)
        {
            var result = await this.Handler.Send(new CreateUserCommand(inputDto));

            return Created($"/{result.User}", result.User);
        }
    }
}
