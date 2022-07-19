using MySpotify.Domain.Album.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpotify.Domain.Album
{
    public class Music
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Duration Duration { get; set; }

    }
}
