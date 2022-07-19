using MySpotify.Application.Users.Dto;

namespace MySpotify.Application.Users.Services
{
    public interface IUserServices
    {
        Task<UserOutputDto> Create(UserInputDto dto);
    }
}