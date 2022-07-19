using AutoMapper;
using MySpotify.Application.Users.Dto;
using MySpotify.Domain.User.Repository;
using System;


namespace MySpotify.Application.Users.Services
{
    internal class UserServices : IUserServices
    {
        private readonly IUserRepository UserRepository;
        private readonly IMapper mapper;

        public UserServices(IUserRepository UserRepository, IMapper mapper)
        {
            this.UserRepository = UserRepository;
            this.mapper = mapper;
        }

        public async Task<UserOutputDto> Create(UserInputDto dto)
        {
            var User = this.mapper.Map<Domain.User.User>(dto);

            await this.UserRepository.Save(User);

            return this.mapper.Map<UserOutputDto>(User);

        }
    }
}
