using Microsoft.EntityFrameworkCore;
using MySpotify.Domain.User;
using MySpotify.Domain.User.Repository;
using MySpotify.Infrastructure.Database;
using MySpotify.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpotify.Repository.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(MySpotifyContext context) : base(context)
        {

        }

        public async Task<User> GetUserByPassword(string username, string password)
        {
            return await this.FindOneByCriteria(x => x.Email.Value == username 
                                                  && x.Password.Value == password);
        }
    }
}
