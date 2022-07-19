using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpotify.Application.Users.Dto
{
    public record UserInputDto(string Name, string DateOfBirth, string Photo, string CPF, string Email, string Password);
    public record UserOutputDto(Guid Id, string Name, string DateOfBirth, string Photo, string CPF, string Email);
}
