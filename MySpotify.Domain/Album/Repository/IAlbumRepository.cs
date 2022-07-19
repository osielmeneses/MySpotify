using MySpotify.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpotify.Domain.Album.Repository
{
    public interface IAlbumRepository : IRepository<Album>
    {
        Task<IEnumerable<Album>> GetAllAlbum();
    }
}
