using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace MySpotify.Repository.Context
{
    public class MySpotifyContext : DbContext
    {
        public MySpotifyContext(DbContextOptions<MySpotifyContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MySpotifyContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ILoggerFactory loggerFactory = LoggerFactory.Create(c => c.AddConsole());

            optionsBuilder.UseLoggerFactory(loggerFactory);

            optionsBuilder.UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }


    }
}
