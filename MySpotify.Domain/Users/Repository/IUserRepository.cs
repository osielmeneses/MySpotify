﻿using MySpotify.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpotify.Domain.User.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetUserByPassword(string username, string password);
    }
}
