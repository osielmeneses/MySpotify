using MySpotify.Application.Users.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpotify.Application.Users.Handler.Commands
{
    public class CreateUserCommandResponse
    {
        public UserOutputDto User { get; set; }

        public CreateUserCommandResponse(UserOutputDto user)
        {
            User = user;
        }
    }
}
