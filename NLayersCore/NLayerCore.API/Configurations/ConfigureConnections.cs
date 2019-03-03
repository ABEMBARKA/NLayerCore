namespace NLayerCore.API.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class ConfigureConnections
    {
        public static IServiceCollection AddConnectionProvider(this IServiceCollection services,
            IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("ConnectionStringName") ?? 
                             "Server=BeServer;Database=DbLayerCore;Trusted_connection=True;";
            services.AddDbContext<MyDbConnection>(options => options.UseSqlServer(connection));
            return services;
        }
    }
}