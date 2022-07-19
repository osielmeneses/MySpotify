using MySpotify.Application.Album.Dto;

namespace MySpotify.Application.Album.Services
{
    public interface IAlbumServices
    {
        Task<AlbumOutputDto> Create(AlbumInputDto dto);
        Task<List<AlbumOutputDto>> GetAll();
    }
}