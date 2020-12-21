using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using TrackMyWork.Context;

namespace TrackMyWork.Migrations
{
    internal class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        private readonly IConfiguration _configuration;

        public ApplicationContextFactory()
        {
            _configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();
        }

        public ApplicationDbContext CreateDbContext(string[] args)
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(connectionString, builder => builder.MigrationsAssembly(Assembly.GetAssembly(typeof(ApplicationContextFactory)).GetName().FullName));

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
