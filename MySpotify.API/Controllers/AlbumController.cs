using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MySpotify.Application.Album.Dto;
using MySpotify.Application.Album.Handler.Commands;
using MySpotify.Application.Album.Handler.Query;

namespace MySpotify.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "user-policy")]
    public class AlbumController : ControllerBase
    {
        public IMediator Handler { get; }

        public AlbumController(IMediator handler)
        {
            Handler = handler;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await this.Handler.Send(new GetAllQueryCommand());

            return Ok(result.Albums);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AlbumInputDto inputDto)
        {
            var result = await this.Handler.Send(new CreateAlbumCommand(inputDto));

            return Created($"/{result.Album.Id}", result.Album);
        }
    }
}
