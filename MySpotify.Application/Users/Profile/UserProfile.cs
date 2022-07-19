using MySpotify.Application.Users.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpotify.Application.Album.Profile
{
    public class UserProfile : AutoMapper.Profile
    {
        public UserProfile()
        {
            CreateMap<Domain.User.User, UserOutputDto>()
                .ForMember(x => x.CPF, f => f.MapFrom(m => m.CPF.Value))
                .ForMember(x => x.Email, f => f.MapFrom(m => m.Email.Value));
                
            CreateMap<UserInputDto, Domain.User.User>();
        }
    }
}
