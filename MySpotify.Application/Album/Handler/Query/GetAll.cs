using MediatR;
using MySpotify.Application.Album.Dto;
using System;
using System.Collections.Generic;

namespace MySpotify.Application.Album.Handler.Query
{
    public class GetAllQueryCommand : IRequest<GetAllQueryCommandResponse>
    {

    }

    public class GetAllQueryCommandResponse
    {
        public List<AlbumOutputDto> Albums { get; set; }

        public GetAllQueryCommandResponse()
        {

        }

        public GetAllQueryCommandResponse(List<AlbumOutputDto> albuns)
        {
            this.Albums = albuns;
        }
    }
}
