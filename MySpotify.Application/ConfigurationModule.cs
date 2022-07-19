using MediatR;
using Microsoft.Extensions.DependencyInjection;
using MySpotify.Application.Album.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MySpotify.Repository;
using MySpotify.Application.Users.Services;

namespace MySpotify.Application
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterApplication(this IServiceCollection services, string connectionString)
        {
            services.RegisterRepository(connectionString);

            services.AddAutoMapper(typeof(Application.ConfigurationModule).Assembly);

            services.AddMediatR(typeof(Application.ConfigurationModule).Assembly);

            services.AddScoped<IAlbumServices, AlbumServices>();

            services.AddScoped<IUserServices, UserServices>();

            return services;

        }
    }
}
