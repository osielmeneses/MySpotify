using Microsoft.EntityFrameworkCore;
using MySpotify.Domain.Album;
using MySpotify.Domain.Album.Repository;
using MySpotify.Infrastructure.Database;
using MySpotify.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpotify.Repository.Repository
{
    public class AlbumRepository : Repository<Album>, IAlbumRepository
    {
        public AlbumRepository(MySpotifyContext context) : base(context)
        {
            
        }

        public async Task<IEnumerable<Album>> GetAllAlbum()
        {
            return await Task.FromResult(this._set.Include(x => x.Musics).AsEnumerable());
        }
    }
}
