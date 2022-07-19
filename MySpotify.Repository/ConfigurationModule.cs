using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MySpotify.Domain.Album.Repository;
using MySpotify.Domain.User.Repository;
using MySpotify.Repository.Context;
using MySpotify.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MySpotify.Repository
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterRepository(this IServiceCollection services, string connectionString)
        {

            services.AddDbContext<MySpotifyContext>(c =>
            {
                c.UseSqlServer(connectionString);
            });

            services.AddScoped<IAlbumRepository, AlbumRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;

        }
    }
}
