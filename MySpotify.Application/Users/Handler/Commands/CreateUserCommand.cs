using MediatR;
using MySpotify.Application.Users.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpotify.Application.Users.Handler.Commands
{
    public class CreateUserCommand : IRequest<CreateUserCommandResponse>
    {
        public UserInputDto User { get; set; }

        public CreateUserCommand(UserInputDto user)
        {
            User = user;
        }
    }
}
